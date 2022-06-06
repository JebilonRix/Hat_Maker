using UnityEngine;

namespace RedPanda.Hat
{
    [System.Serializable]
    public class HatData
    {
        [SerializeField] private GameObject hatPrefab;
        [SerializeField] private HatType hatType;
        [SerializeField] private ColorType colorType;
        [SerializeField] private TextureType textureType;

        public GameObject HatPrefab { get => hatPrefab; }
        public HatType HatType { get => hatType; }
        public ColorType ColorType { get => colorType; }
        public TextureType TextureType { get => textureType; }
    }
}