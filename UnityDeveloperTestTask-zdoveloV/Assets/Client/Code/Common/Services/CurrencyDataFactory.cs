using Client.Code.Common.Data.Currency;
using Client.Code.Common.Services.Assets;
using Client.Code.Common.UI.Elements.Currency;

namespace Client.Code.Common.Services
{
    public class CurrencyDataFactory
    {
        private readonly ProjectAssetsProvider _projectAssetsProvider;

        public CurrencyDataFactory(ProjectAssetsProvider projectAssetsProvider) => _projectAssetsProvider = projectAssetsProvider;

        public CurrencyViewData CreateView(CurrencyData data)
        {
            var config = _projectAssetsProvider.Config.Currency;

            return new CurrencyViewData
            {
                Icon = config.Icons[data.Type],
                Value = data.Value,
                Suffix = config.Suffixes[data.Modifier]
            };
        }
    }
}