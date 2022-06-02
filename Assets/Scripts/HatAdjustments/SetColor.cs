using UnityEngine;

namespace RedPanda.HatAdjustment
{
    public class SetColor : MonoBehaviour
    {
        #region Fields
        [SerializeField] private Material[] colors;
        [SerializeField] private ItemHandler _hatHandler;
        #endregion Fields

        #region Unity Methods
        private void Start()
        {
            if (_hatHandler == null)
            {
                _hatHandler = FindObjectOfType<ItemHandler>();
            }
        }
        #endregion Unity Methods

        #region Public Methods
        /// <summary>
        /// Sets the color of the hat.
        /// </summary>
        /// <param name="index"></param>
        public void SetColorToHat(int index)
        {
            MeshRenderer meshRenderer = _hatHandler.CurrentItem.GetComponentInChildren<MeshRenderer>();

            switch (index)
            {
                case (int)HatColorTypes.White:
                    meshRenderer.material.color = colors[(int)HatColorTypes.White].color;
                    break;

                case (int)HatColorTypes.Cyan:
                    meshRenderer.material.color = colors[(int)HatColorTypes.Cyan].color;
                    break;

                case (int)HatColorTypes.Blue:
                    meshRenderer.material.color = colors[(int)HatColorTypes.Blue].color;
                    break;

                case (int)HatColorTypes.Orange:
                    meshRenderer.material.color = colors[(int)HatColorTypes.Orange].color;
                    break;

                case (int)HatColorTypes.Pink:
                    meshRenderer.material.color = colors[(int)HatColorTypes.Pink].color;
                    break;

                case (int)HatColorTypes.Red:
                    meshRenderer.material.color = colors[(int)HatColorTypes.Red].color;
                    break;
            }
        }
        #endregion Public Methods
    }
}