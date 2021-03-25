using UnityEngine;
using UnityEngine.Events;

namespace Gashapon.Item
{
    public class Sentry : MonoBehaviour
    {
        [SerializeField]
        private GameObject _bullet;

        public void Start()
        {
            GetComponent<Interractible>().SetCallback(new UnityAction(Fire));
        }

        private void Fire()
        {
            var go = Instantiate(_bullet, transform.position + transform.right * .5f, Quaternion.identity);
            go.GetComponent<Rigidbody2D>().AddForce(transform.right * 10f, ForceMode2D.Impulse);
        }
    }
}
