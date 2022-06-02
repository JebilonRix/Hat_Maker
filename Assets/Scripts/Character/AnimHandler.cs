using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RedPanda
{
    public class AnimHandler : MonoBehaviour
    {
        [SerializeField] private Animator animator;

        private void Awake()
        {
            if (animator == null)
            {
                animator = GetComponent<Animator>();
            }
        }
        private void Start()
        {
            SetAnim("Idle");
        }
        public void SetAnim(string animName)
        {
            animator.Play(animName);
        }
    }
}