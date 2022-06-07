using System.Collections.Generic;
using UnityEngine;

namespace RedPanda.Sapka
{
    public class HatManager : MonoBehaviour
    {
        #region Fields
        [SerializeField] private GameObject[] _hats;
        [SerializeField] private Transform _hatPoint;
        [SerializeField] private Material[] _textureMaterial;
        [SerializeField] private Texture2D[] _texture;

        private List<GameObject> _createdHat = new List<GameObject>();
        private GameObject _activeHat;
        private HatStat _stats;
        private int _currentId;
        private int _currentTexture;
        private bool _hasTexture = false;
        #endregion Fields

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
        /// <summary>
        /// This is for ui to set active hat.
        /// </summary>
        public void ActiveHat(int id)
        {
            //if (_stats != null)
            //{
            //    _stats.ResetValues();
            //}

            for (int i = 0; i < _hats.Length; i++)
            {
                if (i == id)
                {
                    _activeHat = _createdHat[i];
                    _activeHat.SetActive(true);
                    _stats = _activeHat.GetComponent<HatStat>();
                }
                else
                {
                    if (_createdHat[i].activeSelf)
                    {
                        _createdHat[i].SetActive(false);
                    }
                }
            }
        }
        /// <summary>
        /// This is for ui to set active hat's color.
        /// </summary>
        public void SetColor(int id)
        {
            _stats.SetColor(id);
            _currentId = id;

            // Debug.Log("current id " + _currentId);

            if (_hasTexture)
            {
                SetTexture(_currentTexture);
            }
        }
        /// <summary>
        /// This is for ui to set active hat's texture.
        /// </summary>
        public void SetTexture(int id)
        {
            _stats.TextureType = (TextureType)id;

            Debug.Log("set texture ");

            if (_stats.TextureType != TextureType.Clear)
            {
                _stats.SetColor(_currentId);

                Material[] materialArray = _stats.Renderer.materials;

                Debug.Log("current texture " + (id).ToString());

                _textureMaterial[id].SetColor("_BaseColor", materialArray[0].color);
                _textureMaterial[id].SetTexture("_BaseMap", _texture[id]);

                materialArray[0] = _textureMaterial[id];
                _stats.Renderer.materials = materialArray;

                _hasTexture = true;
                _currentTexture = id;
            }
            else
            {
                _stats.SetColor(_currentId);
                _hasTexture = false;
            }
        }
        #endregion Public Methods
    }
}