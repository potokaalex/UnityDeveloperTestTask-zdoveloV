using Client.Code.Common.Data;
using Client.Code.Common.Services;
using Client.Code.Common.Services.Assets;
using Client.Code.Common.Services.Assets.Base;
using Client.Code.Common.Services.Input;
using Client.Code.Common.Services.Player;
using UnityEngine;
using Zenject;

namespace Client.Code.Common.Infrastructure
{
    public class ProjectInstaller : MonoInstaller
    {
        [SerializeField] private AssetsConfig _assetsConfig;

        public override void InstallBindings()
        {
            BindAssets();

            Container.Bind<InputFactory>().AsSingle();
            Container.Bind<PlayerProvider>().AsSingle();
            Container.Bind<StoreService>().AsSingle();
            Container.Bind<CurrencyDataFactory>().AsSingle();
            Container.BindInterfacesTo<Bootstrapper>().AsSingle();
        }

        private void BindAssets()
        {
            Container.Bind<AssetsLoader>().AsSingle().WithArguments(_assetsConfig);
            Container.Bind<ProjectAssetsLoader>().AsSingle();
            Container.Bind<ProjectAssetsProvider>().AsSingle();
        }
    }
}