using System.Collections.Generic;
using UnityEngine;

namespace RedPanda.UserInterface
{
    public class UiHandler : MonoBehaviour
    {
        #region Fields
        [SerializeField] private List<GameObject> _uiPrefabs = new List<GameObject>();
        [SerializeField] private GameObject _previousButton;
        [SerializeField] private GameObject _nextButton;
        private int _index = 0;
        #endregion Fields

        #region Unity Methods
        private void Start()
        {
            _nextButton.SetActive(false);
            _previousButton.SetActive(false);

            for (int i = 0; i < _uiPrefabs.Count; i++)
            {
                _uiPrefabs[i].SetActive(false);
            }
        }
        #endregion Unity Methods

        #region Public Methods
        /// <summary>
        /// Activates next UI element.
        /// </summary>
        public void NextUi()
        {
            if (_index == _uiPrefabs.Count - 1)
            {
                return;
            }

            SetIndex(1);
        }
        /// <summary>
        /// Activates previous UI element.
        /// </summary>
        public void PreviousUi()
        {
            if (_index == 0)
            {
                return;
            }

            SetIndex(-1);
        }
        #endregion Public Methods

        #region Private Methods
        private void SetCanvasElement()
        {
            for (int i = 0; i < _uiPrefabs.Count; i++)
            {
                if (i == _index)
                {
                    _uiPrefabs[i].SetActive(true);
                }
                else
                {
                    _uiPrefabs[i].SetActive(false);
                }
            }
        }
        private void SetIndex(int direction)
        {
            _index += direction;

            SetCanvasElement();
        }
        #endregion Private Methods
    }
}