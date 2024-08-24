using System.Collections.Generic;
using Client.Code.Common.Data.Items;

namespace Client.Code.Game.UI.Elements.Windows.Upgrades.Window
{
    public interface IUpgradesWindowModel
    {
        List<ItemType> AvailableItems { get; }
    }
}