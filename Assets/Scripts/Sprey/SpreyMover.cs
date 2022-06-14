using UnityEngine;

namespace RedPanda.Sprey
{
    public class SpreyMover : MonoBehaviour
    {
        #region Fields
        [SerializeField] private float z_Pos;
        [SerializeField] private float x_rotation = 15f;
        [SerializeField] private float z_rotation = 80f;

        private Vector3 rotation = new Vector3(30, 0, 0);
        private UnityEngine.Camera _cam;
        private int _index;
        #endregion Fields

        #region Properties
        // public Vector3 Rotation { get => rotation; set => rotation = value; }
        public int Index
        {
            get
            {
                if (_index < 0)
                {
                    _index = 3;
                }
                if (_index > 3)
                {
                    _index = 0;
                }

                return _index;
            }

            private set => _index = value;
        }
        #endregion Properties

        #region Unity Methods
        private void Start()
        {
            _cam = GameObject.Find("Main Camera").GetComponent<UnityEngine.Camera>();
            SetSmokeDirection(0);
        }
        private void Update()
        {
            transform.position = _cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, z_Pos));

            if (this.isActiveAndEnabled)
            {
                transform.rotation = Quaternion.Euler(rotation);
            }
        }
        #endregion Unity Methods

        #region Public Methods
        public void SetSmokeDirection(int index)
        {
            Index += index;

            Debug.Log("Index: " + Index);

            rotation = Index switch
            {
                1 => new Vector3(x_rotation, -90, z_rotation),
                2 => new Vector3(x_rotation, -180, z_rotation),
                3 => new Vector3(x_rotation, 90, z_rotation),
                _ => new Vector3(x_rotation, 0, z_rotation),
            };
        }
        #endregion Public Methods
    }
}