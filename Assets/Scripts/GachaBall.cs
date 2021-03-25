using UnityEngine;

namespace Gashapon
{
    public class GachaBall : MonoBehaviour
    {
        [SerializeField]
        private SpriteRenderer _sr;

        public void SetColor(Color color)
        {
            _sr.color = color;
        }
    }
}
