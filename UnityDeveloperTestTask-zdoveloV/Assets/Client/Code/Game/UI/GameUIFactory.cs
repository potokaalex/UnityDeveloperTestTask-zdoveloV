using Client.Code.Game.Services.Assets;
using Zenject;

namespace Client.Code.Game.UI
{
    public class GameUIFactory
    {
        private readonly IInstantiator _instantiator;
        private readonly GameAssetsProvider _assetsProvider;

        public GameUIFactory(IInstantiator instantiator, GameAssetsProvider assetsProvider)
        {
            _instantiator = instantiator;
            _assetsProvider = assetsProvider;
        }

        public void CreateCanvas()
        {
            var config = _assetsProvider.GetUI();
            var canvas = _instantiator.InstantiatePrefabForComponent<GameCanvas>(config.CanvasPrefab);
            //этот канвас будет давать рут для окон.
        }
    }
}