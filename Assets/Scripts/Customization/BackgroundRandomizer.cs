using UnityEngine;

namespace RedPanda
{
    public class BackgroundRandomizer : MonoBehaviour
    {
        [SerializeField] private Sprite[] _backgrounds;
        [SerializeField] private SpriteRenderer[] _renderers;

        public void SetRandomBackground()
        {
            int x = Random.Range(0, _backgrounds.Length);

            foreach (SpriteRenderer item in _renderers)
            {
                item.sprite = _backgrounds[x];
            }
        }
    }
}