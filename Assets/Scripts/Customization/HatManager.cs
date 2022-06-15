using UnityEngine;
using PaintIn3D.Examples;

namespace RedPanda.Sapka
{
    public class HatManager : MonoBehaviour
    {
        #region Fields
        [SerializeField] private Transform _hatPoint;
        [SerializeField] private GameObject[] _hats;
        [SerializeField] private P3dButtonClearAll clear;

        private GameObject _activeHat;
        #endregion Fields

        #region Properties
        public GameObject CurrentHat { get => _activeHat; private set => _activeHat = value; }
        #endregion Properties

        #region Public Methods
        public void NoHat()
        {
            Debug.Log("no hat");

            for (int i = 0; i < _hats.Length; i++)
            {
                _hats[i].SetActive(true);
            }

            clear.ClearAll();

            CurrentHat = null;

            for (int i = 0; i < _hats.Length; i++)
            {
                SetDeactive(i);
            }
        }
        /// <summary>
        /// This is for ui to set active hat.
        /// </summary>
        public void ActiveHat(int id)
        {
            for (int i = 0; i < _hats.Length; i++)
            {
                if (i == id)
                {
                    CurrentHat = _hats[i];
                    CurrentHat.SetActive(true);
                }
                else
                {
                    SetDeactive(i);
                }
            }
        }
        #endregion Public Methods

        #region Private Methods
        private void SetDeactive(int i)
        {
            if (_hats[i].activeSelf)
            {
                _hats[i].SetActive(false);
            }
        }
        #endregion Private Methods
    }
}