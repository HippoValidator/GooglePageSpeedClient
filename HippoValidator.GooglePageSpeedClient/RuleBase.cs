using Newtonsoft.Json.Linq;

namespace HippoValidator.GooglePageSpeedClient
{
  public abstract class RuleBase
  {
    protected readonly JObject Jobject;

    public string LocalizedRuleName
    {
      get
      {
        return JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(Jobject, "localizedRuleName"));
      }
    }

    public int RuleScore
    {
      get
      {
        return JsonClassHelper.ReadInteger(JsonClassHelper.GetJToken<JValue>(Jobject, "ruleScore"));
      }
    }

    public int RuleImpact
    {
      get
      {
        return JsonClassHelper.ReadInteger(JsonClassHelper.GetJToken<JValue>(Jobject, "ruleImpact"));
      }
    }

    public RuleBase(JObject obj)
    {
      Jobject = obj;
    }
  }
}
