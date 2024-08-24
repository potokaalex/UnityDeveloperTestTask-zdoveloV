using Client.Code.Common.UI.Base.Window;
using Client.Code.Common.UI.Base.Window.Factory;

namespace Client.Code.Game.UI.Upgrades
{
    public class UpgradesWindowFactory : IWindowFactory
    {
        private readonly IWindowsFactory _windowsFactory;

        public UpgradesWindowFactory(IWindowsFactory windowsFactory) => _windowsFactory = windowsFactory;

        public WindowType Type => WindowType.Upgrades;
        
        public void Create()
        {
            //тут нужны данные сцены, поэтому нужен внешний сервис с данными (сервис нужен по интерфейсу)
            var window = _windowsFactory.Create(WindowType.Upgrades);
            //TODO: setup window (connect it with model!)
            window.Open();
        }

        public void Destroy() => _windowsFactory.Destroy(WindowType.Upgrades);
    }
}