using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RedPanda
{
    [RequireComponent(typeof(Text))]
    public class Scorer : MonoBehaviour
    {
        [SerializeField] private int _follower = 0;
        private Text _text;
        private void Awake()
        {
            if (_text == null)
            {
                _text = GetComponent<Text>();
            }
        }
        public void IncreaseFollowerCount()
        {
            Debug.Log("Follower count increased by ");
            _follower += Random.Range(10, 500);
            _text.text = _follower.ToString();
        }
    }
}
