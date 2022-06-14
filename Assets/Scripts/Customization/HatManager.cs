using System.Collections.Generic;
using UnityEngine;

namespace RedPanda.Sapka
{
    public class HatManager : MonoBehaviour
    {
        #region Fields
        [SerializeField] private Transform _hatPoint;
        [SerializeField] private GameObject[] _hats;
        [SerializeField] private Material[] _textureMaterial;
        [SerializeField] private Texture2D[] _texture;

        private List<GameObject> _createdHat = new List<GameObject>();
        private GameObject _activeHat;
        private HatStat _stats;
        private int _currentId;
        private int _currentTexture;
        private bool _hasTexture = false;

        #endregion Fields

        #region Properties
        public GameObject CurrentHat { get => _activeHat; private set => _activeHat = value; }
        #endregion Properties

        #region Unity Methods
        private void Start()
        {
            for (int i = 0; i < _hats.Length; i++)
            {
                GameObject hat = Instantiate(_hats[i], _hatPoint);
                hat.SetActive(false);
                _createdHat.Add(hat);
            }
            _currentId = 0;
        }
        #endregion Unity Methods

        #region Public Methods
        public void NoHat()
        {
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
                    CurrentHat = _createdHat[i];
                    CurrentHat.SetActive(true);
                    _stats = CurrentHat.GetComponent<HatStat>();
                }
                else
                {
                    SetDeactive(i);
                }
            }
        }
        /// <summary>
        /// This is for ui to set active hat's color.
        /// </summary>
        //public void SetColor(int id)
        //{
        //    if (CurrentHat == null)
        //    {
        //        return;
        //    }

        //    _stats.SetColor(id);
        //    _currentId = id;

        //    if (_hasTexture)
        //    {
        //        SetTexture(_currentTexture);
        //    }
        //}
        /// <summary>
        /// This is for ui to set active hat's texture.
        /// </summary>
        //public void SetTexture(int id)
        //{
        //    if (CurrentHat == null)
        //    {
        //        return;
        //    }

        //    _stats.TextureType = (TextureType)id;

        //    if (_stats.TextureType != TextureType.Clear)
        //    {
        //        _stats.SetColor(_currentId);

        //         Material[] materialArray = _stats.Renderer.materials;

        //        //Material[] materialArray = _hats[id].GetComponent<Renderer>().materials;

        //        _textureMaterial[id].SetColor("_BaseColor", materialArray[0].color);
        //        _textureMaterial[id].SetTexture("_BaseMap", _texture[id]);

  
        //        materialArray[0] = _textureMaterial[id];
        //        _stats.Renderer.materials = materialArray;

        //        _hasTexture = true;
        //        _currentTexture = id;
        //    }
        //    else
        //    {
        //        _stats.SetColor(_currentId);
        //        _hasTexture = false;
        //    }
        //}
        #endregion Public Methods

        #region Private Methods
        private void SetDeactive(int i)
        {
            if (_createdHat[i].activeSelf)
            {
                _createdHat[i].SetActive(false);
            }
        }
        #endregion Private Methods
    }
}