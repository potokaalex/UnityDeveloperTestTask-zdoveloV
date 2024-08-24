namespace Client.Code.Common.UI.Base.Window.Factory
{
    public interface IWindowsFactory
    {
        WindowBase Create(WindowType type);
        void Destroy(WindowType type);
    }
}