using Client.Code.Common.Data.Currency;
using Client.Code.Common.Services;
using Client.Code.Game.Services.Assets;
using Client.Code.Game.UI.Elements;
using UniRx;
using Zenject;

namespace Client.Code.Game.UI.Factories
{
    public class GameUIFactory
    {
        private readonly IInstantiator _instantiator;
        private readonly GameAssetsProvider _assetsProvider;
        private readonly GameUIProvider _provider;
        private readonly GameModel _model;
        private readonly CurrencyDataFactory _currencyDataFactory;

        public GameUIFactory(IInstantiator instantiator, GameAssetsProvider assetsProvider, GameUIProvider provider, GameModel model,
            CurrencyDataFactory currencyDataFactory)
        {
            _instantiator = instantiator;
            _assetsProvider = assetsProvider;
            _provider = provider;
            _model = model;
            _currencyDataFactory = currencyDataFactory;
        }

        public void Create()
        {
            var prefab = _assetsProvider.UI.CanvasPrefab;
            var canvas = _instantiator.InstantiatePrefabForComponent<GameCanvas>(prefab);
            _model.Initialize();
            CreateCurrency(canvas);
            _provider.Initialize(canvas.WindowsRoot);
        }

        private void CreateCurrency(GameCanvas canvas) =>
            _model.GoldCurrency.Subscribe(data => canvas.GoldCurrency.Set(_currencyDataFactory.CreateView(data)));
    }
}