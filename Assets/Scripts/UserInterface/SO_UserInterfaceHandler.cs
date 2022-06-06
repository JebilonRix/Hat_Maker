using UnityEngine;

namespace RedPanda.UserInterface
{
    [CreateAssetMenu(fileName = "SO_UserInterfaceHandler", menuName = "RedPanda/Manager/UserInterface")]
    public class SO_UserInterfaceHandler : ScriptableObject
    {
        #region Fields
        [SerializeField] private UserInterfaceState _userInterfaceState = UserInterfaceState.MainMenu;
        private Initializator _initializator;
        #endregion Fields

        #region Unity Methods
        private void OnDisable()
        {
            _userInterfaceState = UserInterfaceState.MainMenu;
        }
        #endregion Unity Methods

        #region Public Methods
        public void Init(Initializator initializator)
        {
            //for (int i = 0; i < canvases.Length; i++)
            //{
            //    _initilizator[i].canvas = canvases[i];
            //}

            _initializator = initializator;
        }
        public void ChangeState(int id)
        {
            _userInterfaceState = (UserInterfaceState)id;

            switch (_userInterfaceState)
            {
                case UserInterfaceState.MainMenu:
                    _initializator.ObjDic["PlayButton"].SetActive(true);
                    break;

                case UserInterfaceState.HatSelection:
                    break;

                case UserInterfaceState.TextureSelection:
                    break;

                case UserInterfaceState.GlassSelection:
                    break;

                case UserInterfaceState.PoseSeleciton:
                    break;

                case UserInterfaceState.TakePhoto:
                    break;

                case UserInterfaceState.PhotoToPost:
                    break;

                case UserInterfaceState.SocialMedia:
                    break;

                default:
                    break;
            }

            //for (int i = 0; i < _userInterfaceCanvases.Length; i++)
            //{
            //    if (_userInterfaceState == _userInterfaceCanvases[i].userInterfaceState)
            //    {
            //        _userInterfaceCanvases[i].canvas.SetActive(true);
            //    }
            //    else
            //    {
            //        _userInterfaceCanvases[i].canvas.SetActive(false);
            //    }
            //}
        }
        #endregion Public Methods
    }
}