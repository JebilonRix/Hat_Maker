using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using RedPanda.UserInterface;

namespace RedPanda.Photo
{
    [RequireComponent(typeof(Image))]
    public class Flash : MonoBehaviour
    {
        [SerializeField] private Image _flashScene;
        [SerializeField] private float _flashTime = 0.3f;
        [SerializeField] private SO_UserInterfaceHandler _UserInterfaceHandler;

        private void Awake()
        {
            _flashScene = GetComponent<Image>();
        }
        public void FlashScreen()
        {
            StartCoroutine(Flashing());
        }

        private IEnumerator Flashing()
        {
            _flashScene.fillAmount = 0;

            yield return new WaitForSeconds(0.1f);

            //_flashScene.fillAmount = Mathf.Lerp(0, 1, _flashTime);
            _flashScene.fillAmount = 1;

            // yield return new WaitForSeconds(0.1f);
            yield return new WaitForSeconds(_flashTime);

            //_flashScene.fillAmount = Mathf.Lerp(1, 0, _flashTime);
            _flashScene.fillAmount = 0;

            _UserInterfaceHandler.ChangeState(6);
        }
    }
}