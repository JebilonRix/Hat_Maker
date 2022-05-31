using System;
using UnityEngine;

namespace RedPanda
{
    [Serializable]
    internal class Hat
    {
        [SerializeField] private GameObject _hatObject;
        [SerializeField] private Vector3 _hatPosition;
        [SerializeField] private Vector3 _hatRotation;
        [SerializeField] private Vector3 _hatScale;

        public GameObject HatObject { get => _hatObject; }
        public Vector3 HatPosition { get => _hatPosition; }
        public Vector3 HatRotation { get => _hatRotation; }
        public Vector3 HatScale { get => _hatScale; }
    }
}