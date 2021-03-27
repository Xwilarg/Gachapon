using UnityEngine;

namespace Gashapon.Action
{
    public class Shoot : MonoBehaviour
    {
        [SerializeField]
        private GameObject _bullet;

        [SerializeField]
        private GameObject _cartridge;

        private AudioSource _audio;

        private void Start()
        {
            _audio = GetComponent<AudioSource>();
        }

        public void Gunshoot()
        {
            var go = Instantiate(_bullet, transform.position + transform.up * .5f, Quaternion.identity);
            go.GetComponent<Rigidbody2D>().AddForce((transform.up + transform.right * Random.Range(-.1f, .1f)) * 10f, ForceMode2D.Impulse);
            _audio.Play();
            var cartridge = Instantiate(_cartridge, transform.position + transform.up * .4f + transform.right * -.3f, Quaternion.Euler(new Vector3(0f, 0f, Random.Range(0, 250))));
            cartridge.GetComponent<Rigidbody2D>().AddForce((-transform.right + transform.up * Random.Range(-.3f, .3f)) * 200f);
            Destroy(cartridge, 1f);
        }
    }
}
