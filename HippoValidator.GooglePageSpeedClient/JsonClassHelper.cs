using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace HippoValidator.GooglePageSpeedClient
{
    internal static class JsonClassHelper
    {
        public static T GetJToken<T>(JObject obj, string field) where T : JToken
        {
            JToken token;
            return obj.TryGetValue(field, out token) ? GetJToken<T>(token) : default(T);
        }

        private static T GetJToken<T>(JToken token) where T : JToken
        {
            if (token == null)
                return default(T);
            if (token.Type == JTokenType.Null)
                return default(T);
            if (token.Type == JTokenType.Undefined)
                return default(T);
            return (T) token;
        }

        public static string ReadString(JToken token)
        {
            var jtoken = GetJToken<JValue>(token);
            if (jtoken == null)
                return null;
            return (string) jtoken.Value;
        }

        public static bool ReadBoolean(JToken token)
        {
            var jtoken = GetJToken<JValue>(token);
            if (jtoken == null)
                throw new JsonSerializationException();
            return Convert.ToBoolean(jtoken.Value);
        }

        public static bool? ReadNullableBoolean(JToken token)
        {
            var jtoken = GetJToken<JValue>(token);
            return jtoken == null ? new bool?() : Convert.ToBoolean(jtoken.Value);
        }

        public static int ReadInteger(JToken token)
        {
            var jtoken = GetJToken<JValue>(token);
            if (jtoken == null)
                throw new JsonSerializationException();
            return Convert.ToInt32((long) jtoken.Value);
        }

        public static int? ReadNullableInteger(JToken token)
        {
            var jtoken = GetJToken<JValue>(token);
            return jtoken == null ? new int?() : Convert.ToInt32((long) jtoken.Value);
        }

        public static long ReadLong(JToken token)
        {
            var jtoken = GetJToken<JValue>(token);
            if (jtoken == null)
                throw new JsonSerializationException();
            return Convert.ToInt64(jtoken.Value);
        }

        public static long? ReadNullableLong(JToken token)
        {
            var jtoken = GetJToken<JValue>(token);
            return jtoken == null ? new long?() : Convert.ToInt64(jtoken.Value);
        }

        public static double ReadFloat(JToken token)
        {
            var jtoken = GetJToken<JValue>(token);
            if (jtoken == null)
                throw new JsonSerializationException();
            return Convert.ToDouble(jtoken.Value);
        }

        public static double? ReadNullableFloat(JToken token)
        {
            var jtoken = GetJToken<JValue>(token);
            return jtoken == null ? new double?() : Convert.ToDouble(jtoken.Value);
        }

        public static DateTime ReadDate(JToken token)
        {
            var jtoken = GetJToken<JValue>(token);
            if (jtoken == null)
                throw new JsonSerializationException();
            return Convert.ToDateTime(jtoken.Value);
        }

        public static DateTime? ReadNullableDate(JToken token)
        {
            var jtoken = GetJToken<JValue>(token);
            return jtoken == null ? new DateTime?() : Convert.ToDateTime(jtoken.Value);
        }

        public static object ReadObject(JToken token)
        {
            var jtoken = GetJToken<JToken>(token);
            if (jtoken == null)
                return null;
            if (jtoken.Type == JTokenType.Object)
                return jtoken;
            if (jtoken.Type == JTokenType.Array)
                return
                    ReadArray(jtoken,
                              ReadObject);
            var jvalue = jtoken as JValue;
            return jvalue != null ? jvalue.Value : jtoken;
        }

        public static T ReadStronglyTypedObject<T>(JToken token) where T : class
        {
            if (GetJToken<JObject>(token) == null)
                return default(T);
            return (T) Activator.CreateInstance(typeof (T), new object[] {token});
        }

        public static T[] ReadArray<T>(JToken token, ValueReader<T> reader)
        {
            var jtoken = GetJToken<JArray>(token);
            if (jtoken == null)
                return null;
            var objArray = new T[jtoken.Count];
            for (var index = 0; index < objArray.Length; ++index)
                objArray[index] = reader(jtoken[index]);
            return objArray;
        }

        public static Dictionary<string, T> ReadDictionary<T>(JToken token)
        {
            return GetJToken<JObject>(token) == null ? null : new Dictionary<string, T>();
        }

        public static Array ReadArray<TK>(JArray jArray, ValueReader<TK> reader, Type type)
        {
            if (jArray == null)
                return null;
            var elementType = type.GetElementType();
            var instance = Array.CreateInstance(elementType, jArray.Count);
            for (var index = 0; index < instance.Length; ++index)
            {
                if (elementType.IsArray)
                    instance.SetValue(
                        ReadArray(GetJToken<JArray>(jArray[index]), reader,
                                  elementType), index);
                else
                    instance.SetValue(reader(jArray[index]), index);
            }
            return instance;
        }

        public delegate T ValueReader<out T>(JToken token);
    }
}