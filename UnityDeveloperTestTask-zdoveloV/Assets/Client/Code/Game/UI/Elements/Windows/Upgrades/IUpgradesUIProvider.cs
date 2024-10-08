﻿using System.Collections.Generic;
using Client.Code.Common.Data.Items;
using Client.Code.Game.UI.Elements.Windows.Upgrades.Item;
using Client.Code.Game.UI.Elements.Windows.Upgrades.Window;
using UnityEngine;

namespace Client.Code.Game.UI.Elements.Windows.Upgrades
{
    public interface IUpgradesUIProvider
    {
        Transform WindowRoot { get; }
        UpgradesWindow WindowPrefab { get; }
        Dictionary<ItemType, UpgradeItemViewData> Items { get; }
    }
}