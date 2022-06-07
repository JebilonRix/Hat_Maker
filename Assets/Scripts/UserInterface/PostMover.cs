using UnityEngine;

namespace RedPanda.UserInterface
{
    public class PostMover : MonoBehaviour
    {
        [SerializeField] private Transform _photo;
        [SerializeField] private Transform _socialMedia;
        [SerializeField] private RectTransform _rect;

        private void Start()
        {
            MovePost(1);
        }

        public void MovePost(int pos)
        {
            if (pos == 0)
            {
                transform.SetParent(_socialMedia);

                _rect.pivot = Vector2.zero;
                _rect.anchoredPosition3D = new Vector3(59, 1043);
                _rect.sizeDelta = new Vector2(-781, 296);
            }
            else if (pos == 1)
            {
                transform.SetParent(_photo);
                transform.localScale = Vector3.one;

                _rect.pivot = Vector2.zero;
                _rect.anchoredPosition3D = new Vector3(0, 350);
                _rect.sizeDelta = new Vector2(0, 1290);
            }
        }
    }
}