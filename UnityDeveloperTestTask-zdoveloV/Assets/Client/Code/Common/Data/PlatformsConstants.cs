namespace Client.Code.Common.Services.Unity
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