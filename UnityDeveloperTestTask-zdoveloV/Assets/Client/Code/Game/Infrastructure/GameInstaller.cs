using Client.Code.Common.Services;
using Client.Code.Game.Services;
using Client.Code.Game.Services.Assets;
using Client.Code.Game.UI;
using Client.Code.Game.UI.Elements.Upgrades.Window;
using Client.Code.Game.UI.Factories;
using Zenject;

namespace Client.Code.Game.Infrastructure
{
    public class GameInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindAssets();
            BindUI();
            Container.Bind<UpgradeItemDataFactory>().AsSingle();
            Container.BindInterfacesTo<GameStartupper>().AsSingle();
        }

        private void BindAssets()
        {
            Container.Bind<GameAssetsProvider>().AsSingle();
            Container.Bind<GameAssetsLoader>().AsSingle();
        }

        private void BindUI()
        {
            Container.Bind<GameUIFactory>().AsSingle();
            Container.Bind<GameWindowsFactory>().AsSingle();
            Container.BindInterfacesTo<UpgradesWindowFactory>().AsSingle();

            Container.BindInterfacesTo<GamePresenter>().AsSingle();
            Container.BindInterfacesAndSelfTo<GameUIProvider>().AsSingle();
            Container.BindInterfacesTo<GameModel>().AsSingle();
        }
    }
}