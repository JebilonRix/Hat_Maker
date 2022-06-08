using UnityEngine;

namespace RedPanda.Camera
{
    [CreateAssetMenu(fileName = "CameraPositionAndRotation", menuName = "RedPanda/Camera/Position")]
    public class SO_CameraPositionAndRotation : ScriptableObject
    {
        [SerializeField] private Vector3 _cameraPosition;
        [SerializeField] private Vector3 _cameraRotation;

        public Vector3 CameraPosition { get => _cameraPosition; }
        public Vector3 CameraRotation { get => _cameraRotation; }
    }
}