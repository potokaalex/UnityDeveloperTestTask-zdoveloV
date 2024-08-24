using System.Collections.Generic;
using Client.Code.Common.Data.Currency;
using Client.Code.Common.Data.Items;
using Client.Code.Game.Data;
using Client.Code.Game.UI.Elements.Upgrades.Item;
using Client.Code.Game.UI.Elements.Upgrades.Window;

namespace Client.Code.Game.UI
{
    public class GameModel : IUpgradesWindowModel
    {
        public CurrencyData PlayerCurrency = new() { Type = CurrencyType.Gold, Value = 70, Modifier = CurrencyModifierType.Trillions };
        
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