using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Client.Code.Common.UI.Elements.Currency
{
    public class CurrencyView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _text;
        [SerializeField] private Image _icon;

        public void Set(CurrencyViewData data)
        {
            _text.SetText(data.Value + data.Suffix);
            _icon.sprite = data.Icon;
        }
    }
}