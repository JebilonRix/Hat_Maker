using UnityEngine;
using UnityEngine.UI;

namespace RedPanda.UserInterface
{
    public class ButtonSpriteHandler : MonoBehaviour
    {
        [SerializeField] private Image[] _buttonImage;
        [SerializeField] private SO_ButtonSprite[] _buttonSprites;

        public void StayPressed(int index)
        {
            for (int i = 0; i < _buttonImage.Length; i++)
            {
                if (i == index)
                {
                    _buttonImage[i].overrideSprite = _buttonSprites[i].Pressed;
                }
                else
                {
                    _buttonImage[i].overrideSprite = _buttonSprites[i].Default;
                }
            }
        }
    }
}