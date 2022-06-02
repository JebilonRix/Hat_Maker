using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace RedPanda.Photo
{
    public class TakePhotoManager : MonoBehaviour
    {
        #region Fields
        public Camera PhotoCamera;
        public Texture2D[] RenderFreezeTexture;
        public GameObject[] PhotosToMove;
        public RenderTexture _RenderTexture;
        public RawImage[] InstagramShots;
        public Animator CamUI;
        public GameObject InstagramUI;
        public GameObject EmojiHolder;

        private Animator CurrentCharAnim;
        private int ScreenShotNumber = 0;
        private float WaitForNextPhotoTimer = 0f;
        #endregion Fields

        #region Unity Methods
        private void Start()
        {
            // CurrentCharAnim = GameManager.handle.CharAnim;
        }
        private void Update()
        {
            if (WaitForNextPhotoTimer > 0f)
            {
                WaitForNextPhotoTimer -= Time.deltaTime;
            }
        }
        #endregion Unity Methods

        #region Public Methods
        public void PlayCharAnimForPhoto(string _AnimName)
        {
            CurrentCharAnim.Play(_AnimName);
        }
        public void TakeScreenShot()
        {
            if (ScreenShotNumber == 3)
            {
                return;
            }

            if (WaitForNextPhotoTimer > 0)
            {
                return;
            }

            WaitForNextPhotoTimer = 2f;

            PhotosToMove[ScreenShotNumber].SetActive(true);

            RenderFreezeTexture[ScreenShotNumber] = ToTexture2D(_RenderTexture);

            PhotosToMove[ScreenShotNumber].GetComponent<RawImage>().texture = RenderFreezeTexture[ScreenShotNumber];

            InstagramShots[ScreenShotNumber].texture = RenderFreezeTexture[ScreenShotNumber];

            ScreenShotNumber++;

            if (ScreenShotNumber == 3)
            {
                CamUI.SetTrigger("Close");

                InstagramUI.SetActive(true);

                EmojiHolder.SetActive(false);

                StartCoroutine(EndPhotoGamePlay());
            }
        }
        #endregion Public Methods

        #region Private Methods
        private Texture2D ToTexture2D(RenderTexture rTex)
        {
            Texture2D tex = new Texture2D(1024, 1024, TextureFormat.RGB565, false);
            RenderTexture.active = rTex;
            tex.ReadPixels(new Rect(0, 0, rTex.width, rTex.height), 0, 0);
            tex.Apply();
            return tex;
        }
        private IEnumerator EndPhotoGamePlay()
        {
            yield return new WaitForSeconds(3f);

            // GameManager.handle.EndGameSession();
        }
        #endregion Private Methods
    }
}