using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SefIrmak
{
    public class GameManager : MonoBehaviour
    {    
        public void StartGame(){
            SceneManager.LoadScene("Scene 0");
        }

        public void EndGame(){
            SceneManager.LoadScene("MainMenu");
        }
    }
}
