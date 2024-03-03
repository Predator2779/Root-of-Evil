using UnityEngine;

namespace Assets.Scripts.Character.StateMachine.States
{
    public class MovementState 
    {
        private readonly Character _character;
        private CharacterController Controller => _character.Controller;
        private View View => _character.View;
        private CharacterConfig Config => _character.Config;
        private CharacterInput Input => _character.Input;

        public MovementState(Character character) => _character = character;

        public void Update()
        {
            var velocity = ReadInput();

            View.MoveX(velocity.x);
            View.MoveY(velocity.y);

            Controller.Move(velocity * (Config.Speed * Time.deltaTime));
        }
       
        private Vector2 ReadInput() => Input.Gameplay.Move.ReadValue<Vector2>();

    }
}