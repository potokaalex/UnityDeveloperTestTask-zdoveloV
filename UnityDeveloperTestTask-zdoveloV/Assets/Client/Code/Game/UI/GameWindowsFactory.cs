using Client.Code.Common.UI.Base.Window;
using Client.Code.Common.UI.Base.Window.Factory;
using Client.Code.Game.Services.Assets;
using Zenject;

namespace Client.Code.Game.UI
{
    public class GameWindowsFactory : WindowsFactoryBase
    {
        private readonly IInstantiator _instantiator;
        private readonly GameAssetsProvider _assetsProvider;
        private GameCanvas _canvas;

        public GameWindowsFactory(IInstantiator instantiator,GameAssetsProvider assetsProvider)
        {
            _instantiator = instantiator;
            _assetsProvider = assetsProvider;
        }
        
        public void Initialize(GameCanvas canvas) => _canvas = canvas;

        protected override WindowBase CreateNewWindow(WindowType type)
        {
            var prefab = _assetsProvider.GetUI().WindowsPrefabs[type];
            return _instantiator.InstantiatePrefabForComponent<WindowBase>(prefab, _canvas.WindowsRoot);
        }
    }
}