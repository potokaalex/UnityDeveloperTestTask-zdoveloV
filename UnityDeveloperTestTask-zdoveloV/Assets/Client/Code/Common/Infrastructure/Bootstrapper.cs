using Client.Code.Common.Services.Assets;
using Zenject;

namespace Client.Code.Common.Infrastructure
{
    public class Bootstrapper : IInitializable
    {
        private readonly ProjectAssetsLoader _assetsLoader;

        public Bootstrapper(ProjectAssetsLoader assetsLoader) => _assetsLoader = assetsLoader;

        public void Initialize() => _assetsLoader.Load();
    }
}