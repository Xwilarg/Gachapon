using UnityEngine;

namespace Gashapon.Item
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField]
        private GameObject _bloodProjection;

        private Rigidbody2D _rb;

        private void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider.CompareTag("Enemy"))
            {
                var position = (Vector2)collision.collider.transform.position - collision.relativeVelocity.normalized * .5f;
                var projection = Instantiate(_bloodProjection, position, Quaternion.Euler(new Vector3(0f, 90f, 0f)));
                projection.transform.LookAt(transform.position);
                projection.transform.Rotate(new Vector3(180f, 0f, 0f));
                Destroy(projection, 2f);
            }
            Destroy(gameObject);
        }
    }
}
