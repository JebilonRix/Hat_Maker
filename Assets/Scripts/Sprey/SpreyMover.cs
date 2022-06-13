using UnityEngine;

namespace RedPanda.Sprey
{
    public class SpreyMover : MonoBehaviour
    {
        #region Fields
        [SerializeField] private float z_Pos;

        private Vector3 rotation;
        private UnityEngine.Camera _cam;
        #endregion Fields

        #region Properties
        public Vector3 Rotation { get => rotation; set => rotation = value; }
        #endregion Properties

        #region Unity Methods
        private void Start()
        {
            _cam = GameObject.Find("Main Camera").GetComponent<UnityEngine.Camera>();
        }
        private void Update()
        {
            transform.position = _cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, z_Pos));

            if (this.isActiveAndEnabled)
            {
                transform.rotation = Quaternion.Euler(Rotation); 
            }
        }
        #endregion Unity Methods
    }
}