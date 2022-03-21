using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SefIrmak
{
    public class BackgroundScroller : MonoBehaviour
    {
        [SerializeField] private RawImage _img;
        [SerializeField] private float _x,_y;
        
        /// <summary>
        /// Awake is called when the script instance is being loaded.
        /// </summary>
        void Awake()
        {
            _img = GetComponent<RawImage>();
        }
        // Update is called once per frame
        void Update()
        {
            _img.uvRect = new Rect(_img.uvRect.position+ new Vector2(_x, _y)* Time.deltaTime, _img.uvRect.size);
        }
    }
}
