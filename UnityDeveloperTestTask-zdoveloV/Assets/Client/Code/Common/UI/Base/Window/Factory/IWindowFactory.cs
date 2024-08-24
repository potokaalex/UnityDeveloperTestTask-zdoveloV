namespace Client.Code.Common.UI.Base.Window.Factory
{
    public interface IWindowFactory
    {
        WindowType Type { get; }
        void Create();
        void Destroy();
    }
}