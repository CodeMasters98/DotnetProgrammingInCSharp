namespace EnumInCSharp.Enums
{
    [Flags]
    public enum Permissions
    {
        None = 0,
        Read = 1,
        Write = 2,
        Execute = 3
    }
}
