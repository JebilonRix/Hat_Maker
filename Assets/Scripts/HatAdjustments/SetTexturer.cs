using UnityEngine;

namespace RedPanda
{
    public class SetTexturer : MonoBehaviour
    {
        #region Fields
        [SerializeField] private Material[] _textureMaterial;
        [SerializeField] private Texture2D[] _texture;
        [SerializeField] private ItemHandler _itemHandler;
        #endregion Fields

        #region Public Methods
        public void SetTexture(int index)
        {
            MeshRenderer renderer = _itemHandler.CurrentItem.GetComponentInChildren<MeshRenderer>();

            Material[] materialArray = renderer.materials;

            _textureMaterial[index].SetColor("_BaseColor", materialArray[0].color);
            _textureMaterial[index].SetTexture("_BaseMap", _texture[index]);

            materialArray[0] = _textureMaterial[index];
            renderer.materials = materialArray;
        }
        #endregion Public Methods
    }
}