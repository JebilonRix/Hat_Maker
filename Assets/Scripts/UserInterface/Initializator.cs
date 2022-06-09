using System.Collections.Generic;
using UnityEngine;

namespace RedPanda.UserInterface
{
    public class Initializator : MonoBehaviour
    {
        #region Fields
        [Header("Primary")]
        [SerializeField] private SO_UserInterfaceHandler _userInterfaceHandler;
        [SerializeField] private GameObject PlayButton;
        [SerializeField] private GameObject ButtonsHat;
        [SerializeField] private GameObject ButtonsGlass;
        [SerializeField] private GameObject ButtonsTexture;
        [SerializeField] private GameObject PoseSelection;
        [SerializeField] private GameObject TakePhoto;
        [SerializeField] private GameObject PhotoToPost;
        [SerializeField] private GameObject SocialMedia;

        [Header("Secondary")]
        [SerializeField] private GameObject SelectionArea;
        [SerializeField] private GameObject ButtonsColor;

        private Dictionary<UserInterfaceState, GameObject> _objDic = new Dictionary<UserInterfaceState, GameObject>();
        #endregion Fields

        #region Unity Methods
        private void Start()
        {
            _objDic.Add(UserInterfaceState.MainMenu, PlayButton);
            _objDic.Add(UserInterfaceState.HatSelection, ButtonsHat);
            _objDic.Add(UserInterfaceState.GlassSelection, ButtonsGlass);
            _objDic.Add(UserInterfaceState.TextureSelection, ButtonsTexture);
            _objDic.Add(UserInterfaceState.PoseSelection, PoseSelection);
            _objDic.Add(UserInterfaceState.TakePhoto, TakePhoto);
            _objDic.Add(UserInterfaceState.PhotoToPost, PhotoToPost);
            _objDic.Add(UserInterfaceState.SocialMedia, SocialMedia);
            _objDic.Add(UserInterfaceState.ColorSelection, ButtonsColor);

            _userInterfaceHandler.Init(this);
        }
        #endregion Unity Methods

        #region Public Methods
        /// <summary>
        /// Keywords: PlayButton, ButtonsHat, ButtonsGlass, ButtonsTexture
        /// </summary>
        public void SetActivation(UserInterfaceState tag, bool needColor, bool needSelectionArea)
        {
            foreach (var item in _objDic)
            {
                if (item.Value.activeSelf)
                {
                    item.Value.SetActive(false);
                }
            }

            _objDic[tag].SetActive(true);

            NeedCheck(SelectionArea, needSelectionArea);
            NeedCheck(ButtonsColor, needColor);
        }
        #endregion Public Methods

        #region Private Methods
        private void NeedCheck(GameObject obj, bool needArea)
        {
            if (needArea)
            {
                if (!obj.activeSelf)
                {
                    obj.SetActive(true);
                }
            }
            else
            {
                if (obj.activeSelf)
                {
                    obj.SetActive(false);
                }
            }
        }
        #endregion Private Methods
    }
}