using Client.Code.Game.Data;

namespace Client.Code.Game.Services.Assets
{
    public class GameAssetsProvider
    {
        private GameConfig _config;

        public GameUIConfig UI => _config.UI;

        public void Initialize(GameConfig config) => _config = config;
    }
}