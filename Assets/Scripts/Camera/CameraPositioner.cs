using RedPanda.Sprey;
using RedPanda.UserInterface;
using System.Collections.Generic;
using UnityEngine;

namespace RedPanda.Camera
{
    public class CameraPositioner : MonoBehaviour
    {
        #region Fields
        [SerializeField] private SO_UserInterfaceHandler _userInterfaceHandler;
        [SerializeField] private SpreyMover _mover;
        [SerializeField] private List<SO_CameraPositionAndRotation> _cameraPositions;

        [SerializeField] private SO_CameraPositionAndRotation front;//4
        [SerializeField] private SO_CameraPositionAndRotation right;//5
        [SerializeField] private SO_CameraPositionAndRotation back;//6
        [SerializeField] private SO_CameraPositionAndRotation left;//7

        private int _coloringIndex = 4;

        #endregion Fields

        #region Properties
        public int ColoringIndex
        {
            get
            {
                if (_coloringIndex < 4)
                {
                    _coloringIndex = 7;
                }
                else if (_coloringIndex > 7)
                {
                    _coloringIndex = 4;
                }

                return _coloringIndex;
            }

            private set => _coloringIndex = value;
        }
        #endregion Properties

        #region Unity Methods
        private void Start()
        {
            ColoringIndex = 4;

            _cameraPositions.Add(front);
            _cameraPositions.Add(right);
            _cameraPositions.Add(back);
            _cameraPositions.Add(left);
        }
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
                    MoveCamera(3);
                    break;

                case UserInterfaceState.GlassSelection:
                    MoveCamera(2);
                    break;

                case UserInterfaceState.PoseSelection:
                    MoveCamera(0);
                    break;

                case UserInterfaceState.TakePhoto:

                    break;

                case UserInterfaceState.PhotoToPost:

                    break;

                case UserInterfaceState.SocialMedia:

                    break;

                case UserInterfaceState.ColorSelection:
                    MoveCamera(ColoringIndex);

                    break;
            }
        }
        #endregion Unity Methods

        #region Public Methods
        public void ColoringPositions(int way)
        {
            ColoringIndex += way;

            _mover.Rotation = _cameraPositions[ColoringIndex].CameraRotation;
        }
        #endregion Public Methods

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