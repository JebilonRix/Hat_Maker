using RedPanda.UserInterface;
using UnityEngine;

namespace RedPanda.Camera
{
    public class CameraPositioner : MonoBehaviour
    {
        #region Fields
        [SerializeField] private SO_UserInterfaceHandler _userInterfaceHandler;
        [SerializeField] private SO_CameraPositionAndRotation[] _cameraPositions;
        #endregion Fields

        #region Unity Methods
        private void LateUpdate()
        {
            switch (_userInterfaceHandler.UserInterfaceState)
            {
                case UserInterfaceState.MainMenu:
                    MoveCamera(0);
                    break;

                case UserInterfaceState.HatSelection:
                    MoveCamera(1);
                    break;

                case UserInterfaceState.TextureSelection:
                    MoveCamera(1);
                    break;

                case UserInterfaceState.GlassSelection:
                    MoveCamera(2);
                    break;

                case UserInterfaceState.PoseSelection:
                    MoveCamera(0);
                    break;

                case UserInterfaceState.TakePhoto:
                    MoveCamera(0);
                    break;

                case UserInterfaceState.PhotoToPost:
                    MoveCamera(0);
                    break;

                case UserInterfaceState.SocialMedia:
                    MoveCamera(0);
                    break;
            }
        }
        #endregion Unity Methods

        #region Private Methods
        private void MoveCamera(int id)
        {
            if (transform.position != _cameraPositions[id].CameraPosition)
            {
                transform.position = Vector3.MoveTowards(transform.position, _cameraPositions[id].CameraPosition, Time.deltaTime * 10);
            }

            if (transform.rotation != Quaternion.Euler(_cameraPositions[id].CameraRotation))
            {
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(_cameraPositions[id].CameraRotation), Time.deltaTime * 10);
            }
        }
        #endregion Private Methods
    }
}