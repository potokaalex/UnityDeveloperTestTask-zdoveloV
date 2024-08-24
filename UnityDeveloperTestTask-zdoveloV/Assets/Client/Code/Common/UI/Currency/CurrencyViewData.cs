using System;
using UnityEngine;

namespace Client.Code.Common.UI.Currency
{
    [Serializable]
    public class CurrencyViewData
    {
        public Sprite Icon;
        public int Value;
        public string Suffix;
    }
}