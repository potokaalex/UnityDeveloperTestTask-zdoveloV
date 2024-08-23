using Client.Code.Game.Services.Assets;
using Client.Code.Game.UI;
using Zenject;

namespace Client.Code.Game.Infrastructure
{
    public class GameStartupper : IInitializable
    {
        private readonly GameAssetsLoader _assetsLoader;
        private readonly GameUIFactory _uiFactory;

        public GameStartupper(GameAssetsLoader assetsLoader, GameUIFactory uiFactory)
        {
            _assetsLoader = assetsLoader;
            _uiFactory = uiFactory;
        }

        public void Initialize()
        {
            _assetsLoader.Load();
            _uiFactory.CreateCanvas();
        }
    }
}