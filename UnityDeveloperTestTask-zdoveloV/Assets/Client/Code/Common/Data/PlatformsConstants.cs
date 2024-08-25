namespace Client.Code.Common.Data
{
    public static class PlatformsConstants
    {
        public static readonly bool IsEditor;

        static PlatformsConstants()
        {
#if UNITY_EDITOR
            IsEditor = true;
#endif
        }
    }
}