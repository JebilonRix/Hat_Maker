using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RedPanda.UserInterface
{
    [CreateAssetMenu(fileName = "ButtonSprite", menuName = "RedPanda/UserInterface/Sprites")]
    public class SO_ButtonSprite : ScriptableObject
    {
        [SerializeField] private Sprite _default;
        [SerializeField] private Sprite _pressed;

        public Sprite Default { get => _default; }
        public Sprite Pressed { get => _pressed; }
    }
}