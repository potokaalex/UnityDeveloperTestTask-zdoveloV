using UnityEngine;
using UnityEngine.UI;

namespace Client.Code.Common.UI.Base
{
    [RequireComponent(typeof(Button))]
    public abstract class ButtonBase : MonoBehaviour
    {
        private Button _baseButton;

        private void Awake()
        {
            _baseButton = gameObject.GetComponent<Button>();
            _baseButton.onClick.AddListener(OnClick);
        }

        private void OnDestroy() => _baseButton.onClick.RemoveListener(OnClick);

        private protected abstract void OnClick();
    }
}