using UnityEngine;

namespace SefIrmak
{
    public class Bomb : MonoBehaviour
    {
        [SerializeField] private float moveSpeed = 5f;
        public static float yRange = -4.9f;
        
        void Update()
        {
            // Destroy the object as soon as they exit the level boundary
            if (this.transform.position.y < yRange)
            {
                Debug.Log("Game Over");
                Destroy(this.gameObject);
                // Get the reference to the game object and its script
                BombCatcher bcScript = GameObject.Find("BombCatcher").GetComponent<BombCatcher>();
                bcScript.BombDestroyed();                
            }
            // move the bomb downward as soon as Instantiated
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }

    }
}
