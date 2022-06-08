using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RedPanda
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class BackgroundRandomizer : MonoBehaviour
    {
        [SerializeField] private Sprite[] _backgrounds;
        SpriteRenderer _renderer;

        private void Awake()
        {
            if (_renderer == null)
            {
                _renderer = GetComponent<SpriteRenderer>();
            }
        }

        public void SetRandomBackground()
        {
            _renderer.sprite = _backgrounds[Random.Range(0, _backgrounds.Length)];
        }
    }
}