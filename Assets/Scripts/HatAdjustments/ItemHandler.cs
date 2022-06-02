using System.Collections.Generic;
using UnityEngine;

namespace RedPanda
{
    public class ItemHandler : MonoBehaviour
    {
        #region Fields
        [SerializeField] private List<GameObject> _hats = new List<GameObject>();
        private GameObject _currentItem;
        #endregion Fields

        #region Properties
        public GameObject CurrentItem { get => _currentItem; private set => _currentItem = value; }
        #endregion Properties

        #region Unity Methods
        private void Start()
        {
            for (int i = 0; i < _hats.Count; i++)
            {
                _hats[i].SetActive(false);
            }
        }
        #endregion Unity Methods

        #region Public Methods
        /// <summary>
        /// This method is for changing hats with buttons.
        /// </summary>
        public void ChangeItem(int index)
        {
            for (int i = 0; i < _hats.Count; i++)
            {
                if (i == index)
                {
                    _hats[i].SetActive(true);
                    CurrentItem = _hats[i];
                }
                else
                {
                    _hats[i].SetActive(false);
                }
            }
        }
        #endregion Public Methods
    }
}