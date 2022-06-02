using UnityEngine;
using UnityEngine.UI;

namespace RedPanda
{
    public class Photocu : MonoBehaviour
    {
        #region Fields
        [SerializeField] private RenderTexture _renderTexture;
        [SerializeField] private Texture2D _texture2D;
        [SerializeField] private RawImage _photo;
        #endregion Fields

        #region Unity Methods
        //private void Update()
        //{
        //    if (Input.GetKeyDown(KeyCode.R))
        //    {
        //        _photo.texture = ToTexture2D(_renderTexture);
        //    }
        //}
        #endregion Unity Methods

        #region Public Methods
        public void TakePhoto()
        {
            _photo.texture = ToTexture2D(_renderTexture);
        }
        #endregion Public Methods

        #region Private Methods
        private Texture2D ToTexture2D(RenderTexture rTex)
        {
            _texture2D = new Texture2D(1024, 1024, TextureFormat.RGB565, false);

            RenderTexture.active = rTex;

            _texture2D.ReadPixels(new Rect(0, 0, rTex.width, rTex.height), 0, 0);

            _texture2D.Apply();

            return _texture2D;
        }
        #endregion Private Methods
    }
}