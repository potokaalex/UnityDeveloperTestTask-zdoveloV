using Client.Code.Game.Services.Assets;
using Client.Code.Game.UI;
using Client.Code.Game.UI.Upgrades;
using Zenject;

namespace Client.Code.Game.Infrastructure
{
    public class GameInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindAssets();
            BindUI();
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
            Container.BindInterfacesTo<GamePresenter>().AsSingle();
            Container.BindInterfacesAndSelfTo<GameWindowsFactory>().AsSingle();
            Container.BindInterfacesTo<UpgradesWindowFactory>().AsSingle();
        }
    }
}