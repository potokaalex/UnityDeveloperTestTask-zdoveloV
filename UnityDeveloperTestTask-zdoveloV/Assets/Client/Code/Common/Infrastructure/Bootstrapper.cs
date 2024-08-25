using Client.Code.Common.Services;
using Client.Code.Common.Services.Assets;
using Zenject;

namespace Client.Code.Common.Infrastructure
{
    public class Bootstrapper : IInitializable
    {
        private readonly ProjectAssetsLoader _assetsLoader;
        private readonly StoreService _storeService;

        public Bootstrapper(ProjectAssetsLoader assetsLoader, StoreService storeService)
        {
            _assetsLoader = assetsLoader;
            _storeService = storeService;
        }

        public void Initialize()
        {
            _assetsLoader.Load();
            _storeService.Initialize();
        }
    }
}