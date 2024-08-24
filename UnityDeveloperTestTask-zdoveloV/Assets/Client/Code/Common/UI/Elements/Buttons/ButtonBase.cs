using UnityEngine;
using UnityEngine.UI;

namespace Client.Code.Common.UI.Elements.Buttons
{
    [RequireComponent(typeof(Button))]
    public abstract class ButtonBase : MonoBehaviour
    {
        private Button _baseButton;

        protected Button BaseButton
        {
            get
            {
                if (!_baseButton)
                    _baseButton = gameObject.GetComponent<Button>();
                return _baseButton;
            }
        }

        private void Awake() => BaseButton.onClick.AddListener(OnClick);

        private void OnDestroy() => BaseButton.onClick.RemoveListener(OnClick);

        protected abstract void OnClick();
    }
}