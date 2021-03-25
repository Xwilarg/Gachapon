using UnityEngine;
using UnityEngine.Events;

namespace Gashapon.Item
{
    public class Sentry : MonoBehaviour
    {
        [SerializeField]
        private GameObject _bullet;

        [SerializeField]
        private GameObject _cartridge;

        private AudioSource _audio;

        public void Start()
        {
            GetComponent<Interractible>().SetCallback(new UnityAction(Fire));
            _audio = GetComponent<AudioSource>();
        }

        private void Fire()
        {
            var go = Instantiate(_bullet, transform.position + transform.right * .5f, Quaternion.identity);
            go.GetComponent<Rigidbody2D>().AddForce((transform.right + transform.up * Random.Range(-.1f, .1f)) * 10f, ForceMode2D.Impulse);
            _audio.Play();
            var cartridge = Instantiate(_cartridge, transform.position + transform.right * .4f + transform.up * -.3f, Quaternion.Euler(new Vector3(0f, 0f, Random.Range(0, 250))));
            cartridge.GetComponent<Rigidbody2D>().AddForce((-transform.up + transform.right * Random.Range(-.3f, .3f)) * 200f);
            Destroy(cartridge, 1f);
        }
    }
}
