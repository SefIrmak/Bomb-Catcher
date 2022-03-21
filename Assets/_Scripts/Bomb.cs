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
                // UPDATES THE GAME MANAGER TO LOSE HEALTH (IF HEALTH<=0 ROLL END LOGIC)
                
            }
            // move the bomb downward as soon as Instantiated
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }

    }
}
