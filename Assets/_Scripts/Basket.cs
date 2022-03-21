using UnityEngine;
using TMPro;

namespace SefIrmak
{
    public class Basket : MonoBehaviour
    {
        [Header("Set Dynamically")]
        public TextMeshProUGUI scoreText;
       
      
        void Start()
        {
            GameObject scoreGO = GameObject.Find("ScoreCounter");
            scoreText = scoreGO.GetComponent<TextMeshProUGUI>();
            scoreText.text = "0";
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Bomb"))
            {  
                // add point
                int scorePoint = int.Parse(scoreText.text);
                scorePoint += 100;
                scoreText.text = scorePoint.ToString();
                // destroy bomb object
                Destroy(other.gameObject);
            }
           
        }
    }
}
