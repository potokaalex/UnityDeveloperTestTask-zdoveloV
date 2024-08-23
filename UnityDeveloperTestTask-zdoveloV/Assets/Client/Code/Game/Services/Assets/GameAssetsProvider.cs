using Client.Code.Game.Data;

namespace Client.Code.Game.Services.Assets
{
    public class GameAssetsProvider
    {
        private GameConfig _config;

        public void Initialize(GameConfig config) => _config = config;

        public GameUIConfig GetUI() => _config.UI;
    }
}