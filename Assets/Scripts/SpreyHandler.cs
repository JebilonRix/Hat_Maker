using PaintIn3D;
using UnityEngine;

namespace RedPanda
{
    public class SpreyHandler : MonoBehaviour
    {
        #region Fields
        [SerializeField] private GameObject _spreyPrefab;
        private ParticleSystem.MainModule _smokeColor;
        private ParticleSystem _smoke;
        private P3dPaintSphere _paint;
        #endregion Fields

        #region Unity Methods
        private void Awake()
        {
            _smoke = _spreyPrefab.GetComponent<ParticleSystem>();
            _smokeColor = _smoke.main;
            _paint = _spreyPrefab.GetComponent<P3dPaintSphere>();
        }
        private void Start()
        {
            DeactiveSprey();
        }
        #endregion Unity Methods

        #region Public Methods
        public void SetPrefab(string colorName)
        {
            _spreyPrefab.SetActive(true);

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

            _paint.Color = selectedColor;
            _smokeColor.startColor = new ParticleSystem.MinMaxGradient(selectedColor);

            _smoke.Play();
        }
        public void DeactiveSprey()
        {
            _smoke.Stop();
            _spreyPrefab.SetActive(false);
        }
        #endregion Public Methods
    }
}