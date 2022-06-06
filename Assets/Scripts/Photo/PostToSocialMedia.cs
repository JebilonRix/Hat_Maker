using RedPanda.UserInterface;
using UnityEngine;

namespace RedPanda.Photo
{
    public class PostToSocialMedia : MonoBehaviour
    {
        [SerializeField] private SO_UserInterfaceHandler _userInterfaceHandler;
        [SerializeField] private GameObject _post;
        [SerializeField] private Vector3 _photoPosition;
        [SerializeField] private float _postSpeed = 0.5f;
        private bool _lerpStarted = false;

        private void Update()
        {
            if (_lerpStarted)
            {
                Vector3.Lerp(_post.transform.position, _photoPosition, _postSpeed);

                Vector3.Lerp(_post.transform.localScale, new Vector3(0.3f, 0.3f, 0.3f), _postSpeed);
            }
        }

        public void Test()
        {
            _post.transform.SetParent(transform);
            _lerpStarted = true;
            Invoke(nameof(CloseLerp), _postSpeed + 0.1f);
        }
        private void CloseLerp()
        {
            _lerpStarted = false;
        }
    }
}