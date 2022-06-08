using UnityEngine;

namespace RedPanda.UserInterface
{
    [CreateAssetMenu(fileName = "LevelCounter", menuName = "RedPanda/LevelCounter")]
    public class SO_LevelCounter : ScriptableObject
    {
        [SerializeField] private int _level = 1;
        public int Level { get => _level; set => _level = value; }

        private void OnDisable()
        {
            Level = 1;
        }

        public void IncrementLevel()
        {
            Level++;
        }
    }
}