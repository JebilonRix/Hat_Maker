using System.Collections.Generic;
using UnityEngine;

namespace RedPanda
{
    [CreateAssetMenu(fileName = "HatHolder", menuName = "RedPanda/Manager/HatHolder")]
    public class SO_HatHolder : ScriptableObject
    {
        #region Fields
        [SerializeField] private List<Hat> _hats = new List<Hat>();
        private List<GameObject> _hatsInGame = new List<GameObject>();
        #endregion Fields

        #region Unity Functions
        private void OnDisable()
        {
            _hatsInGame = new List<GameObject>();
        }
        #endregion Unity Functions

        #region Public Methods
        /// <summary>
        /// This method must be called in Start method.
        /// </summary>
        public void Init()
        {
            for (int i = 0; i < _hats.Count; i++)
            {
                _hatsInGame.Add(Instantiate(_hats[i].HatObject));
            }

            for (int i = 0; i < _hats.Count; i++)
            {
                GameObject hat = _hatsInGame[i];

                hat.transform.position = _hats[i].HatPosition;
                hat.transform.rotation = Quaternion.Euler(_hats[i].HatRotation);
                hat.transform.localScale = _hats[i].HatScale;
                hat.SetActive(false);
            }
        }
        /// <summary>
        /// This method is for changing hats with buttons.
        /// </summary>
        public void ChangeActivationHat(int index)
        {
            for (int i = 0; i < _hats.Count; i++)
            {
                if (i == index)
                {
                    _hatsInGame[i].SetActive(true);
                }
                else
                {
                    _hatsInGame[i].SetActive(false);
                }
            }
        }
        #endregion Public Methods
    }
}