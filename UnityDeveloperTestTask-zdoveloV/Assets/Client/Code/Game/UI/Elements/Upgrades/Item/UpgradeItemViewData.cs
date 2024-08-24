using System;
using Client.Code.Game.UI.Elements.Currency;
using UnityEngine;

namespace Client.Code.Game.UI.Elements.Upgrades.Item
{
    [Serializable]
    public class UpgradeItemViewData
    {
        public UpgradeItemUI Prefab;
        public Sprite Icon;
        public string Description;
        public string SubDescription;
        public CurrencyViewData Price;
    }
}