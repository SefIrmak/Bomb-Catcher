using UnityEngine;

namespace SefIrmak
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float moveSpeed = 10f;
        [SerializeField] private float xRange = 7.24f;

        // Update is called once per frame
        void Update()
        {
            CheckBoundary();
            MovePlayer();
        }

        private void CheckBoundary()
        {
            var position = transform.position;
            if (transform.position.x < -xRange)
            {
                position = new Vector3(-xRange, 0f, 0f);
                transform.position = position;
            }

            if (transform.position.x > xRange)
            {
                position = new Vector3(xRange, 0f, 0f);
                transform.position = position;
            }
        }

        private void MovePlayer()
        {
            Vector3 inputDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0f).normalized;
            Vector3 velocity = inputDirection * moveSpeed;
            this.transform.Translate(velocity * Time.deltaTime);
        }
    }
}
