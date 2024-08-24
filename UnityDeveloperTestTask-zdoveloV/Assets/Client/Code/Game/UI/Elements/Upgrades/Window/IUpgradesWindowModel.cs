using System.Collections.Generic;
using Client.Code.Common.Data.Items;
using Client.Code.Game.Data;
using Client.Code.Game.UI.Elements.Upgrades.Item;

namespace Client.Code.Game.UI.Elements.Upgrades.Window
{
    public interface IUpgradesWindowModel
    {
        List<ItemType> AvailableItems { get; }
    }
}