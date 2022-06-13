using PaintIn3D;
using UnityEngine;

namespace RedPanda.Sprey
{
    public class SpreyHandler : MonoBehaviour
    {
        #region Fields
        [SerializeField] private GameObject _spreyObjectPrefab;

        private ParticleSystem.MainModule _smokeColor;
        private ParticleSystem _smoke;
        private P3dPaintSphere _paint;
        private MeshRenderer _meshRenderer;
        #endregion Fields

        #region Unity Methods
        private void Awake()
        {
            _smoke = _spreyObjectPrefab.GetComponent<ParticleSystem>();
            _smokeColor = _smoke.main;

            _meshRenderer = _spreyObjectPrefab.GetComponent<MeshRenderer>();
            _paint = _spreyObjectPrefab.GetComponent<P3dPaintSphere>();
        }
        private void Start()
        {
            DeactiveSprey();
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _smoke.Play();
            }
            else if (Input.GetMouseButtonUp(0))
            {
                _smoke.Stop();
            }
        }
        #endregion Unity Methods

        #region Public Methods
        public void ActiveSprey(string colorName)
        {
            _spreyObjectPrefab.SetActive(true);

            Color selectedColor = Color.red;

            if (colorName.ToLower() == "red")
            {
                selectedColor = Color.red;
            }
            else if (colorName.ToLower() == "green")
            {
                selectedColor = Color.green;
            }
            else if (colorName.ToLower() == "blue")
            {
                selectedColor = Color.blue;
            }
            else if (colorName.ToLower() == "yellow")
            {
                selectedColor = Color.yellow;
            }
            else if (colorName.ToLower() == "cyan")
            {
                selectedColor = Color.cyan;
            }
            else if (colorName.ToLower() == "white")
            {
                selectedColor = Color.white;
            }
            else if (colorName.ToLower() == "pink")
            {
                selectedColor = new Color(241, 145, 208);
            }
            else if (colorName.ToLower() == "orange")
            {
                selectedColor = new Color(242, 65, 48);
            }

            Material[] colors = _meshRenderer.materials;
            colors[1].color = selectedColor;

            _paint.Color = selectedColor;
            _smokeColor.startColor = new ParticleSystem.MinMaxGradient(selectedColor);
        }
        public void DeactiveSprey()
        {
            _smoke.Stop();
            _spreyObjectPrefab.SetActive(false);
        }
        #endregion Public Methods
    }
}