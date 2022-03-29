using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace SefIrmak
{
    public class HighScore : MonoBehaviour
    {
        static public int score = 1000;
      
        private void Awake() {
            if (PlayerPrefs.HasKey("HighScore"))
            {
                score = PlayerPrefs.GetInt("HighScore");
            }
            PlayerPrefs.SetInt("HighScore", score);
        }
        void Update()
        {
            TextMeshProUGUI highscoreText = this.GetComponent<TextMeshProUGUI>();
            highscoreText.text = "Highscore: " +score;

            if (score > PlayerPrefs.GetInt("HighScore"))
            {
                PlayerPrefs.SetInt("HighScore", score);
            }
        } 
    }
}