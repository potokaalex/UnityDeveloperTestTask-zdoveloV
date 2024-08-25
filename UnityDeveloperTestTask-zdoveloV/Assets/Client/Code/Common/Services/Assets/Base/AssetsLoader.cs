using Client.Code.Common.Data;

namespace Client.Code.Common.Services.Assets.Base
{
    public class AssetsLoader
    {
        private readonly AssetsConfig _config;

        public AssetsLoader(AssetsConfig config) => _config = config;

        public T Load<T>(AssetKey key) where T : ILoadableAsset => (T)_config.Assets[key];
    }
}