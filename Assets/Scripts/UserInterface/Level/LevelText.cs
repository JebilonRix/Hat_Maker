using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RedPanda.UserInterface
{
    [RequireComponent(typeof(Text))]
    public class LevelText : MonoBehaviour
    {
        [SerializeField] private SO_LevelCounter _counter;
        private Text _text;

        private void Awake()
        {
            if (_text == null)
            {
                _text = GetComponent<Text>();
            }
        }
        public void SetLevel()
        {
            _text.text = _counter.Level.ToString();
        }
    }
}
