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
            _initializator = initializator;
            ChangeState(0);
        }
        public void ChangeState(int id)
        {
            _userInterfaceState = (UserInterfaceState)id;

            bool colorsNeeded = false;
            bool selectionAreaNeeded = false;

            switch (_userInterfaceState)
            {
                case UserInterfaceState.MainMenu:
                    break;

                case UserInterfaceState.HatSelection:
                    selectionAreaNeeded = true;
                    colorsNeeded = true;
                    break;

                case UserInterfaceState.TextureSelection:
                    selectionAreaNeeded = true;
                    colorsNeeded = true;
                    break;

                case UserInterfaceState.GlassSelection:
                    selectionAreaNeeded = true;
                    colorsNeeded = false;
                    break;

                case UserInterfaceState.PoseSelection:
                    break;

                case UserInterfaceState.TakePhoto:
                    break;

                case UserInterfaceState.PhotoToPost:
                    break;

                case UserInterfaceState.SocialMedia:
                    break;
            }

            _initializator.SetActivation(_userInterfaceState, colorsNeeded, selectionAreaNeeded);

            //Debug.Log(id + " id");
            //Debug.Log(_userInterfaceState + " user interface state");
            //Debug.Log(colorsNeeded + " colorsNeeded");
            //Debug.Log(selectionAreaNeeded + " selectionAreaNeeded");
        }
        #endregion Public Methods
    }
}