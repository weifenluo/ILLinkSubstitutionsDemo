public static class DbTypes
{
    internal static bool IsDbEnabled { get; } = AppContext.TryGetSwitch("DbTypes.IsDbEnabled", out var result) ? result : false;

    public static string Message
    {
        get
        {
            if (IsDbEnabled)
                return "DbEnabled";
            else
                return "DbDisabled";
        }
    }
}
