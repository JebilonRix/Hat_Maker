using UnityEngine;

namespace RedPanda.Sprey
{
    public class SpreyMover : MonoBehaviour
    {
        #region Fields
        [SerializeField] private float z_Pos;
        
        private Camera _cam;
        #endregion Fields

        #region Unity Methods
        private void Update()
        {
            transform.position = _cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, z_Pos));
        }
        private void Start()
        {
            _cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        }
        #endregion Unity Methods
    }
}