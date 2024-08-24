namespace Client.Code.Common.UI.Base.Window
{
    public interface IWindowFactory
    {
        WindowType Type { get; }
        void Create();
        void Destroy();
    }
}