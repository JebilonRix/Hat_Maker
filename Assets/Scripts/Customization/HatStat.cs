using UnityEngine;

namespace RedPanda.Sapka
{
    [RequireComponent(typeof(MeshRenderer))]
    public class HatStat : MonoBehaviour
    {
        #region Fields
        [SerializeField] private Material _defaultMaterial;
        //[SerializeField] private ColorType colorType = ColorType.White;
        //[SerializeField] private TextureType textureType = TextureType.Clear;
        //[SerializeField] private List<ColorSelect> _combines = new List<ColorSelect>();
        //private MeshRenderer _renderer;
        #endregion Fields

        #region Properties
        // public TextureType TextureType { get => textureType; set => textureType = value; }
        //  public MeshRenderer Renderer { get => _renderer; set => _renderer = value; }
        #endregion Properties

        #region Unity Methods
        //private void Awake()
        //{
        //    //if (Renderer == null)
        //    //{
        //    //    Renderer = GetComponent<MeshRenderer>();
        //    //}
        //}
        //private void Start()
        //{
        //    ResetValues();
        //}
        //private void OnDisable()
        //{
        //    ResetValues();
        //}
        #endregion Unity Methods

        #region Public Methods
        /// <summary>
        /// Button method to change color type.
        /// </summary>
        //public void SetColor(int id)
        //{
        //     colorType = (ColorType)id;

        //    Material[] mat = Renderer.materials;

        //    for (int i = 0; i < mat.Length; i++)
        //    {
        //        // mat[i] = _combines[id].materials[i];
        //    }

        //    Renderer.materials = mat;
        //}
        public void ResetValues()
        {
            //colorType = ColorType.White;
            //TextureType = TextureType.Clear;

            MeshRenderer ren = GetComponent<MeshRenderer>();

            Material[] mat = ren.materials;

            Debug.Log(mat.Length);

            for (int i = 0; i < mat.Length; i++)
            {
                mat[i] = new Material(_defaultMaterial);
            }

            ren.materials = mat;
        }
        #endregion Public Methods
    }

    //[System.Serializable]
    //internal struct ColorSelect
    //{
    //    public ColorType colorType;
    //    public Material[] materials;
    //}
}