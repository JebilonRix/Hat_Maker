using UnityEngine;

namespace RedPanda
{
    public class Spawner : MonoBehaviour
    {
        #region Fields
        [SerializeField] private SO_HatHolder _hatHolder;
        #endregion Fields

        #region Unity Methods
        private void Start()
        {
            _hatHolder.Init();
        }
        #endregion Unity Methods
    }
}