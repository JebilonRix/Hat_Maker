using RedPanda.Hat;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RedPanda.Hat
{
    [CreateAssetMenu(fileName = "Hat", menuName = "RedPanda/Hat")]
    public class SO_Hat : ScriptableObject
    {
        [Header("Positioning")]
        [SerializeField] private GameObject _hatPrefab;
        [SerializeField] private Vector3 _hatPos;
        [SerializeField] private Vector3 _hatRot;
        [SerializeField] private Vector3 _hatScale;

        [Header("Query")]
        [SerializeField] private HatType _hatType;
        // [SerializeField] private ColorType _colorType;
        // [SerializeField] private TextureType _textureType;

        private GameObject _createdHat;

        public HatType HatType { get => _hatType; }
        //  public ColorType ColorType { get => _colorType; }
        // public TextureType TextureType { get => _textureType; }
        public GameObject CreatedHat { get => _createdHat; private set => _createdHat = value; }

        private void CreateHats()
        {
            //5 -> hats
            for (int h = 0; h < 5; h++)
            {
                //6 -> colors
                for (int i = 0; i < 6; i++)
                {
                    //4 -> textures
                    for (int j = 0; j < 4; j++)
                    {
                        CreatedHat = Instantiate(_hatPrefab);
                        var newHat = CreatedHat.AddComponent<HatDataa>();
                        // newHat.HatType = (HatType)h;
                        // newHat.ColorType = (ColorType)i;
                        //  newHat.TextureType = (TextureType)j;

                        SetTransform(newHat.gameObject);
                    }
                }
            }
        }

        private void SetTransform(GameObject obj)
        {
            obj.transform.SetPositionAndRotation(_hatPos, Quaternion.Euler(_hatRot));
            obj.transform.localScale = _hatScale;
        }
    }
}