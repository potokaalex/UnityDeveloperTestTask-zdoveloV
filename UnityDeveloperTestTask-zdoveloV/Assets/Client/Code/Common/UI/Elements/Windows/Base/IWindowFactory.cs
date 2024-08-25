namespace Client.Code.Common.UI.Elements.Windows.Base
{
    public interface IWindowFactory
    {
        WindowType Type { get; }
        void Create();
        void Destroy();
    }
}