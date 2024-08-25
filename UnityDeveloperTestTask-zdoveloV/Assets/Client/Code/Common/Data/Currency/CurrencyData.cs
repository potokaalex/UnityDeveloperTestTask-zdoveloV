using System;
using UnityEngine;

namespace Client.Code.Common.Data.Currency
{
    [Serializable]
    public struct CurrencyData
    {
        public CurrencyType Type;
        public double Value;
        [SerializeField] private CurrencyModifierType _modifier;

        public CurrencyData(CurrencyType type, double value, CurrencyModifierType modifier)
        {
            Type = type;
            Value = value;
            _modifier = modifier;
        }

        public CurrencyModifierType Modifier => _modifier;

        public static CurrencyData operator +(CurrencyData a, CurrencyData b)
        {
            AssertTypesMatch(a, b);
            return FromDouble(a.ToDouble() + b.ToDouble(), a.Type);
        }

        public static CurrencyData operator -(CurrencyData a, CurrencyData b)
        {
            AssertTypesMatch(a, b);
            return FromDouble(a.ToDouble() - b.ToDouble(), a.Type);
        }

        public static bool operator <=(CurrencyData a, CurrencyData b)
        {
            AssertTypesMatch(a, b);
            return a.ToDouble() <= b.ToDouble();
        }

        public static bool operator >=(CurrencyData a, CurrencyData b)
        {
            AssertTypesMatch(a, b);
            return a.ToDouble() >= b.ToDouble();
        }

        private double ToDouble() => Value * Math.Pow(10, (int)_modifier);

        private static CurrencyData FromDouble(double doubleValue, CurrencyType type)
        {
            if (doubleValue == 0)
                return new CurrencyData(type, 0, CurrencyModifierType.None);

            var log10 = (int)Math.Floor(Math.Log10(Math.Abs(doubleValue)));
            var exp = log10 - log10 % 3;
            var value = doubleValue / Math.Pow(10, exp);
            return new CurrencyData(type, value, (CurrencyModifierType)exp);
        }

        private static void AssertTypesMatch(CurrencyData a, CurrencyData b)
        {
            if (a.Type != b.Type)
                throw new InvalidOperationException("Currency types do not match.");
        }
    }
}