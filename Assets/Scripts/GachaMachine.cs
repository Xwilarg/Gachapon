using UnityEngine;

namespace Gashapon
{
    public class GachaMachine : MonoBehaviour
    {
        [SerializeField]
        private GameObject _gachaBall;

        private void OnMouseDown()
        {
            var go = Instantiate(_gachaBall, transform);
            go.GetComponent<GachaBall>().SetColor(Color.red);
        }
    }
}
