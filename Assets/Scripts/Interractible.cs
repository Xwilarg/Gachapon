using UnityEngine;
using UnityEngine.Events;

namespace Gashapon
{
    public class Interractible : MonoBehaviour
    {
        private UnityEvent _event;

        public void SetCallback(UnityAction callback)
        {
            _event.AddListener(callback);
        }

        public void Invoke()
        {
            _event.Invoke();
        }
    }
}
