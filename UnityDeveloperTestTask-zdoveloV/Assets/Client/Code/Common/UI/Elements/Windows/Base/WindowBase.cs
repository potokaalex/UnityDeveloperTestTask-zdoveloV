using Sirenix.OdinInspector;
using UnityEngine;

namespace Client.Code.Common.UI.Elements.Windows.Base
{
    public abstract class WindowBase : SerializedMonoBehaviour
    {
        [SerializeField] private bool _isAnimated;
        [SerializeField] [ShowIf(nameof(_isAnimated))] private WindowAnimator _animator;

        public void Open()
        {
            if (_isAnimated)
                _animator.PlayOpen();
            else
                gameObject.SetActive(true);
        }

        public void Close()
        {
            if (_isAnimated)
                _animator.PlayClose();
            else
                gameObject.SetActive(false);
        }

        public void ForceClose() => gameObject.SetActive(false);
    }
}