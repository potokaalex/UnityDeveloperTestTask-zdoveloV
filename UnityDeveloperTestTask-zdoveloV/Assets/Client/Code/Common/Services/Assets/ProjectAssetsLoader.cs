using Client.Code.Common.Data;
using Client.Code.Common.Services.Assets.Base;

namespace Client.Code.Common.Services.Assets
{
    public class ProjectAssetsLoader
    {
        private readonly AssetsLoader _loader;
        private readonly ProjectAssetsProvider _provider;

        public ProjectAssetsLoader(AssetsLoader loader, ProjectAssetsProvider provider)
        {
            _loader = loader;
            _provider = provider;
        }

        public void Load()
        {
            var config = _loader.Load<ProjectConfig>(AssetKey.Project);
            _provider.Initialize(config);
        } 
    }
}