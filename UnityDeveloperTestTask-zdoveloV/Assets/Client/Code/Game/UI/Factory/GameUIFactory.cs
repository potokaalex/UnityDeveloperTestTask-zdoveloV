using Client.Code.Game.Services.Assets;
using Client.Code.Game.UI.Elements;
using Zenject;

namespace Client.Code.Game.UI.Factory
{
    public class GameUIFactory
    {
        private readonly IInstantiator _instantiator;
        private readonly GameAssetsProvider _assetsProvider;
        private readonly GameUIProvider _provider;

        public GameUIFactory(IInstantiator instantiator, GameAssetsProvider assetsProvider, GameUIProvider provider)
        {
            _instantiator = instantiator;
            _assetsProvider = assetsProvider;
            _provider = provider;
        }

        public void Create()
        {
            var prefab = _assetsProvider.UI.CanvasPrefab;
            var canvas = _instantiator.InstantiatePrefabForComponent<GameCanvas>(prefab);
            _provider.Initialize(canvas.WindowsRoot);
        }
    }
}