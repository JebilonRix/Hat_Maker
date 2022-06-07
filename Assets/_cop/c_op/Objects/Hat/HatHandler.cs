using System.Collections.Generic;
using UnityEngine;

namespace RedPanda.Hat
{
    public class HatHandler : MonoBehaviour
    {
        #region Fields
        [SerializeField] private HatData[] hatDatas;

        private HatType hatType = HatType.None;
        //  private ColorType colorType = ColorType.White;
        //   private TextureType textureType = TextureType.Clear;
        private List<GameObject> _hatsList = new List<GameObject>();
        #endregion Fields

        #region Unity Methods
        private void Start()
        {
            hatType = HatType.None;

            for (int i = 0; i < hatDatas.Length; i++)
            {
                //GameObject hat = Instantiate(hatDatas[i].HatPrefab);
                // hatDatas[i].HatPrefab.SetActive(false);

                _hatsList.Add(hatDatas[i].HatPrefab);
            }
        }
        #endregion Unity Methods

        #region Public Methods
        /// <summary>
        /// Button method to change hat type.
        /// </summary>
        public void SetHat(int id)
        {
            hatType = (HatType)id;
            SetHat();

            Debug.Log("Hat type: " + hatType);
        }
        /// <summary>
        /// Button method to change color type.
        /// </summary>
        public void SetColor(int id)
        {
            if (hatType == HatType.None)
            {
                return;
            }

            // colorType = (ColorType)id;
            SetHat();
            //   Debug.Log("Color type: " + colorType);
        }
        /// <summary>
        /// Button method to change texture type.
        /// </summary>
        public void SetTexture(int id)
        {
            if (hatType == HatType.None)
            {
                return;
            }

            //   textureType = (TextureType)id;
            SetHat();
            //   Debug.Log("Texture type: " + textureType);
        }
        #endregion Public Methods

        #region Private Methods
        /// <summary>
        /// Sets the correct hat with key enums.
        /// </summary>
        private void SetHat()
        {
            for (int i = 0; i < hatDatas.Length; i++)
            {
                //   //  if (hatType == hatDatas[i].HatType && colorType == hatDatas[i].ColorType && textureType == hatDatas[i].TextureType)
                //   //  {
                //   //      _hatsList[i].SetActive(true);
                //   //  }
                //   //  else
                //     {
                //  //       if (_hatsList[i].activeSelf)
                // //        {
                ///             _hatsList[i].SetActive(false);
                //         }
                // //    }
            }
        }
        #endregion Private Methods
    }
}