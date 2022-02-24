using UnityEngine;

namespace SefIrmak
{
    public class BombCatcher : MonoBehaviour
    {
        [Header("Set in Inspector")] 
        public GameObject basketPrefab;
        private int _numBaskets = 3;
        public GameObject[] basketsArray; 
        
        public float basketBottomY = -2.25f;
        public float basketSpacingY = -0.75f;
            
        // Start is called before the first frame update
        void Start()
        {
            basketsArray = new GameObject[_numBaskets];
            for (int i = 0; i < _numBaskets; i++)
            {
                basketsArray[i] = Instantiate(basketPrefab,transform);
                Vector3 pos = Vector3.zero;
                pos.y = basketBottomY + (basketSpacingY * i);
                basketsArray[i].transform.position = pos;
            }
        }
    }
}
