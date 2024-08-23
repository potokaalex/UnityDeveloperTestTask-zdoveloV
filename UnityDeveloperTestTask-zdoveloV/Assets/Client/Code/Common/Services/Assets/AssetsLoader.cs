namespace Client.Code.Common.Services.Assets
{
    public class AssetsLoader
    {
        private readonly AssetsConfig _config;

        public AssetsLoader(AssetsConfig config) => _config = config;

        public T Load<T>(AssetKey key) where T : IAsset => (T)_config.Assets[key];
    }
}