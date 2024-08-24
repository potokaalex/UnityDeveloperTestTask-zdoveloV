namespace Client.Code.Common.UI.Elements.Windows
{
    public interface IWindowFactory
    {
        WindowType Type { get; }
        void Create();
        void Destroy();
    }
}