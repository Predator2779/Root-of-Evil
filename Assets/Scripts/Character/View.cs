using UnityEngine;

namespace Assets.Scripts.Character
{
    public class View 
    {
        private Animator _animator;

        private const string IsMovementX = "MovementX";
        private const string IsMovementY = "MovementY";

        public View(Animator animator) => _animator = animator;

        public void MoveX(float x) => _animator.SetFloat(IsMovementX, x);
        public void MoveY(float y) => _animator.SetFloat(IsMovementY, y);
    }
}


