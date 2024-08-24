using System.Collections.Generic;
using Client.Code.Common.Data.Currency;
using Client.Code.Common.Data.Items;
using Client.Code.Game.UI.Elements.Windows.Upgrades.Window;
using UniRx;

namespace Client.Code.Game.UI
{
    public class GameModel : IUpgradesWindowModel
    {
        public readonly ReactiveProperty<CurrencyData> Currency = new(new CurrencyData(CurrencyType.Gold, 70, CurrencyModifierType.Trillions));

        public List<ItemType> AvailableItems { get; } = new()
        {
            ItemType.WatchATutorial,
            ItemType.MadeWithLove,
            ItemType.MaturedForLonger,
            ItemType.VisitAUniversityJobFair,
            ItemType.BiggerPortion
        };
    }
}