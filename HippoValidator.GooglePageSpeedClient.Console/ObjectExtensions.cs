namespace HippoValidator.GooglePageSpeedClient.Console
{
  public static class ObjectExtensions
  {
    public static void WriteIfSet(this object o)
    {
      if (o == null)
        return;
      System.Console.WriteLine(" - {0}: {1}", o.GetType().Name, o.GetType().GetProperty("RuleScore").GetValue(o, null));
    }
  }
}
