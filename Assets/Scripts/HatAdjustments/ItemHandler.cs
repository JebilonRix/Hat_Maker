using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RedPanda
{
    public class ItemHandler : MonoBehaviour
    {
        [SerializeField] private List<GameObject> _hats = new List<GameObject>();

        private void Start()
        {
            for (int i = 0; i < _hats.Count; i++)
            {
                _hats[i].SetActive(false);
            }
        }
    }
}