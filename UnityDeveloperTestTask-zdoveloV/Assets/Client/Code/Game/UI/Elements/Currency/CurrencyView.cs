using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Client.Code.Game.UI.Elements.Currency
{
    public class CurrencyView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _text;
        [SerializeField] private Image _icon;

        public void Initialize(CurrencyViewData data)
        {
            _text.SetText(data.Value.ToString());
            _icon.sprite = data.Icon;
        }
    }
}