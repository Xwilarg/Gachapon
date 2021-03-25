using UnityEngine;

namespace Gashapon.Player
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField]
        private GameObject _pressE;

        private Rigidbody2D _rb;

        private Interractible _target;

        private void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate()
        {
            _rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * 4f;

            var mousePos = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 dir = (mousePos - (Vector2)transform.position).normalized;
            transform.up = dir;
        }

        private void Update()
        {
            var hit = Physics2D.Raycast(transform.position + transform.up * .5f, transform.up);
            if (hit.point != null && hit.distance < .3f)
            {
                var component = hit.collider.GetComponent<Interractible>();
                _pressE.SetActive(component != null);
                _target = component;
            } else {
                _pressE.SetActive(false);
                _target = null;
            }

            if (_target != null && Input.GetKeyDown(KeyCode.E)) // Use action
            {
                _target.Invoke();
            }
        }
    }
}
