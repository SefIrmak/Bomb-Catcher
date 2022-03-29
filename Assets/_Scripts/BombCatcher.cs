using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SefIrmak
{
    // this GameObject is responsible for creating and managing baskets as in player life
    public class BombCatcher : MonoBehaviour
    {
        [Header("Set in Inspector")]
        public GameObject basketPrefab;
        private int _numBaskets = 3;
        public List<GameObject> basketsList; 
        public float basketBottomY = -2.25f;
        public float basketSpacingY = -0.75f;  

        void Start()
        {
            basketsList = new List<GameObject>();
            for (int i = 0; i < _numBaskets; i++)
            {
                // Instantiate baskets as children of BombCatcher GameObject!
                GameObject tBasketGO = Instantiate(basketPrefab,transform);
                Vector3 pos = Vector3.zero;
                pos.y = basketBottomY + (basketSpacingY * i);
                tBasketGO.transform.position = pos;
                basketsList.Add(tBasketGO);
            }
        }
        
        // this method is called when player is fail to catch the bomb.
        public void BombDestroyed(){
            GameObject [] tBombsArray = GameObject.FindGameObjectsWithTag("Bomb");
            foreach (GameObject tGO in tBombsArray)
            {
                Destroy(tGO);
            }
            // if player doesn't have remaining baskets
            GameManager gameManagerScript = Camera.main.GetComponent<GameManager>();
            if (basketsList.Count == 0)
            {                   
                // restart the scene
                gameManagerScript.EndGame();                
            }
            else{
                // Destroy one of the baskets
                int basketIndex = basketsList.Count-1;
                GameObject tBasketGO = basketsList[basketIndex];
                basketsList.RemoveAt(basketIndex);
                Destroy(tBasketGO);
            }            
        }
    }
}
