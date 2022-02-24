using UnityEngine;
using Random = UnityEngine.Random;

namespace SefIrmak
{
    public class Bomber : MonoBehaviour
    {
        [Header("Set in the Inspector")]
        public Transform firePoint;
        public GameObject bombPrefab;

        [SerializeField] private float _xRangeOffset = 8f;
        [SerializeField] private float _moveSpeed = 10f;
        [SerializeField] private float _secondsBetweenDrops = 1f;
        [SerializeField] private float _chanceToChangeDirection = .1f;
        
    
        // Start is called before the first frame update
        void Start() {
            
            Invoke("DropBomb",2f);
        }
        private void DropBomb()
        {
            Instantiate<GameObject>(bombPrefab, firePoint.position, Quaternion.identity);
            Invoke("DropBomb", _secondsBetweenDrops);
        }

        void Update()
        {
            // Bomber simple movement logic goes here
            Vector3 pos = this.transform.position;
            pos.x += _moveSpeed * Time.deltaTime;
            transform.position = pos;
            
            // Changing Direction
            if (pos.x < -_xRangeOffset)
            {
                _moveSpeed = Mathf.Abs(_moveSpeed); // move right
            }else if (pos.x > _xRangeOffset)
            {
                _moveSpeed = -Mathf.Abs(_moveSpeed); // move left
            }
        }

        private void FixedUpdate()
        {
            if (Random.value < _chanceToChangeDirection)
            {
                _moveSpeed *= -1; // change direction
            }
        }

    }
}
