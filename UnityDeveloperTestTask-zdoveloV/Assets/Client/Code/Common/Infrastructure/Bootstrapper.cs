using Client.Code.Common.Services;
using Client.Code.Common.Services.Assets;
using Client.Code.Common.Services.Input;
using Zenject;

namespace Client.Code.Common.Infrastructure
{
    public class Bootstrapper : IInitializable
    {
        private readonly ProjectAssetsLoader _assetsLoader;
        private readonly StoreService _storeService;
        private readonly InputFactory _inputFactory;

        public Bootstrapper(ProjectAssetsLoader assetsLoader, StoreService storeService, InputFactory inputFactory)
        {
            _assetsLoader = assetsLoader;
            _storeService = storeService;
            _inputFactory = inputFactory;
        }

        public void Initialize()
        {
            _assetsLoader.Load();
            _storeService.Initialize();
            _inputFactory.Create();
        }
    }
}