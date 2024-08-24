using UnityEngine;

namespace Client.Code.Common.UI.Elements.Windows
{
    public abstract class WindowBase : MonoBehaviour
    {
        public abstract WindowType BaseType { get; }

        public void Open() => gameObject.SetActive(true);

        public void Close() => gameObject.SetActive(false);

        public void ForceClose() => gameObject.SetActive(false);
    }
}