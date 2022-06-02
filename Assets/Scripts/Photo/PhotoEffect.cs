using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace RedPanda
{
    public class PhotoEffect : MonoBehaviour
    {
        #region Fields
        [SerializeField] private GameObject _ui;
        [SerializeField] private Image _flashImage;
        [SerializeField] private GameObject _photo;
        [SerializeField] private float _flashTime = 0.5f;
        #endregion Fields

        #region Public Methods
        public void Flash_Button()
        {
            StartCoroutine(FlashEffect());
        }
        #endregion Public Methods

        #region Private Methods
        private IEnumerator FlashEffect()
        {
            _ui.SetActive(false);
            _photo.SetActive(false);
            _flashImage.gameObject.SetActive(true);
            _flashImage.fillAmount = 0;

            yield return new WaitForSeconds(_flashTime);

            _flashImage.fillAmount = 1;

            yield return new WaitForSeconds(_flashTime);

            _photo.SetActive(true);
            _flashImage.fillAmount = 0;

            yield return new WaitForSeconds(_flashTime);

            _flashImage.gameObject.SetActive(false);
        }
        #endregion Private Methods
    }
}