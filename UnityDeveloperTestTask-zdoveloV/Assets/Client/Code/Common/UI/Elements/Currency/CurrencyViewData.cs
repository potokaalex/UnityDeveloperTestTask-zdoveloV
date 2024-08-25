using System;
using UnityEngine;

namespace Client.Code.Common.UI.Elements.Currency
{
    [Serializable]
    public class CurrencyViewData
    {
        public Sprite Icon;
        public double Value;
        public string Suffix;
    }
}