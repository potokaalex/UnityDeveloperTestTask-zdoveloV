using Client.Code.Game.Services.Assets;
using Zenject;

namespace Client.Code.Game.UI
{
    public class GameUIFactory
    {
        private readonly IInstantiator _instantiator;
        private readonly GameAssetsProvider _assetsProvider;
        private readonly GameWindowsFactory _windowsFactory;

        public GameUIFactory(IInstantiator instantiator, GameAssetsProvider assetsProvider, GameWindowsFactory windowsFactory)
        {
            _instantiator = instantiator;
            _assetsProvider = assetsProvider;
            _windowsFactory = windowsFactory;
        }

        public void CreateCanvas()
        {
            var config = _assetsProvider.GetUI();
            var canvas = _instantiator.InstantiatePrefabForComponent<GameCanvas>(config.CanvasPrefab);
            _windowsFactory.Initialize(canvas);
        }
    }
}