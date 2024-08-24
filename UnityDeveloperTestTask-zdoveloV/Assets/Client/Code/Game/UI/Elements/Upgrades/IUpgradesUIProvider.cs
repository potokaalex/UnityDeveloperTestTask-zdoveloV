using System.Collections.Generic;
using Client.Code.Game.Data;
using Client.Code.Game.UI.Elements.Upgrades.Item;
using Client.Code.Game.UI.Elements.Upgrades.Window;
using UnityEngine;

namespace Client.Code.Game.UI.Elements.Upgrades
{
    public interface IUpgradesUIProvider
    {
        UpgradesWindow WindowPrefab { get; }
        UpgradeItemView ItemPrefab { get; }
        
        Transform WindowRoot { get; }
    }
}