using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Client.Code.Game.UI.Elements.Currency
{
    public class CurrencyView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _text;
        [SerializeField] private Image _icon;

        private static readonly Dictionary<long, string> _suffixes = new()
        {
            { 1_000_000_000_000_000, "Q" },
            { 1_000_000_000_000, "T" },
            { 1_000_000_000, "B" },
            { 1_000_000, "M" },
            { 1_000, "K" }
        };

        public void Initialize(CurrencyViewData data)
        {
            _text.SetText(FormatCurrency(data.Value));
            _icon.sprite = data.Icon;
        }

        private static string FormatCurrency(long value)
        {
            foreach (var suffix in _suffixes)
                if (value >= suffix.Key)
                    return (value / (float)suffix.Key).ToString("0.#") + suffix.Value;

            return value.ToString();
        }
    }
}