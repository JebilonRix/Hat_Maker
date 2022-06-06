using UnityEngine;

namespace RedPanda
{
    public class GlassHandler : MonoBehaviour
    {
        #region Fields
        [SerializeField] private Transform _glassPosition;
        [SerializeField] private GameObject[] _glassPrefabs;
        #endregion Fields

        #region Unity Methods
        private void Start()
        {
            for (int i = 0; i < _glassPrefabs.Length; i++)
            {
                GameObject obj = _glassPrefabs[i];
                obj.transform.position = _glassPosition.position;
                obj.SetActive(false);
            }
        }
        #endregion Unity Methods

        #region Public Methods
        public void SetGlasses(int id)
        {
            for (int i = 0; i < _glassPrefabs.Length; i++)
            {
                _glassPrefabs[i].SetActive(i == id);
            }
        }
        #endregion Public Methods
    }
}