using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RedPanda.HatAdjustment
{
    public class SetColor : MonoBehaviour
    {
        public void SetColorToHat(int index)
        {
            switch (index)
            {
                case (int)HatColorTypes.White:
                    break;

                case (int)HatColorTypes.Cyan:
                    break;

                case (int)HatColorTypes.Blue:
                    break;

                case (int)HatColorTypes.Orange:
                    break;

                case (int)HatColorTypes.Pink:
                    break;

                case (int)HatColorTypes.Red:
                    break;
            }
        }
    }

    public enum HatColorTypes
    {
        White = 0,
        Cyan = 1,
        Blue = 2,
        Orange = 3,
        Pink = 4,
        Red = 5
    }
}