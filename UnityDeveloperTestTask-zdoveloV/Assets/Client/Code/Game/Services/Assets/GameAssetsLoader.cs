using Client.Code.Common.Services.Assets;
using Client.Code.Common.Services.Assets.Base;
using Client.Code.Game.Data;

namespace Client.Code.Game.Services.Assets
{
    public class GameAssetsLoader
    {
        private readonly AssetsLoader _loader;
        private readonly GameAssetsProvider _provider;

        public GameAssetsLoader(AssetsLoader loader, GameAssetsProvider provider)
        {
            _loader = loader;
            _provider = provider;
        }

        public void Load()
        {
            var config = _loader.Load<GameConfig>(AssetKey.Game);
            _provider.Initialize(config);
        }
    }
}