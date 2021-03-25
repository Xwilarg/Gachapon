using UnityEngine;
using UnityEngine.Events;

namespace Gashapon
{
    public class Interractible : MonoBehaviour
    {
        private UnityEvent _event = new UnityEvent();

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
