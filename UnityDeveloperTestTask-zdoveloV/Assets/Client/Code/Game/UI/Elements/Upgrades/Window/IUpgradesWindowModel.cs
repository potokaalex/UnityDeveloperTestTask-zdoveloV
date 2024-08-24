using System.Collections.Generic;
using Client.Code.Game.Data;

namespace Client.Code.Game.UI.Elements.Upgrades.Window
{
    public interface IUpgradesWindowModel
    {
        List<UpgradeItemType> AvailableItems { get; }
    }
}