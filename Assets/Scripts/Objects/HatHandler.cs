using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RedPanda.Hat
{
    public class HatHandler : MonoBehaviour
    {
        [SerializeField] private HatData[] hatDatas;
        private HatType hatType;
        private ColorType colorType;
        private TextureType textureType;

        public void SetHat(int id)
        {
            hatType = (HatType)id;
            SetHat();
        }
        public void SetColor(int id)
        {
            colorType = (ColorType)id;
            SetHat();
        }
        public void SetTexture(int id)
        {
            textureType = (TextureType)id;
            SetHat();
        }
        private void SetHat()
        {
            for (int i = 0; i < hatDatas.Length; i++)
            {
                if (hatType == hatDatas[i].hatType && colorType == hatDatas[i].colorType && textureType == hatDatas[i].textureType)
                {
                    hatDatas[i].hat.SetActive(true);
                }
                else
                {
                    if (hatDatas[i].hat.activeSelf)
                    {
                        hatDatas[i].hat.SetActive(false);
                    }
                }
            }
        }
    }

    public enum HatType
    {
        Cap,
        Safari,
        Milkman,
        French,
        SummerHat
    }

    public enum ColorType
    {
        White,
        Pink,
        Blue,
        Cyan,
        Purple,
        Orange,
        Red
    }

    public enum TextureType
    {
        None,
        Quad,
        Diamond,
        Stars
    }

    [System.Serializable]
    public class HatData
    {
        public GameObject hat;
        public HatType hatType;
        public ColorType colorType;
        public TextureType textureType;
    }
}