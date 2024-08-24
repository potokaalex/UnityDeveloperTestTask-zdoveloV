using System;

namespace Client.Code.Common.Data.Currency
{
    [Serializable]
    public class CurrencyData
    {
        public CurrencyType Type;
        public int Value;
        public CurrencyModifierType Modifier;
    }
}