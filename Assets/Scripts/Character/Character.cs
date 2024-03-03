using Assets.Scripts.Character.StateMachine.States;
using UnityEngine;

namespace Assets.Scripts.Character
{
    [RequireComponent(typeof(CharacterController))]
    public class Character : MonoBehaviour
    {
        [SerializeField] private CharacterConfig _config;
        [SerializeField] private Animator _animator;

        private CharacterInput _input;
        private CharacterController _controller;
        private MovementState _movement;
        private View _view;

        public CharacterInput Input => _input;
        public CharacterController Controller => _controller;
        public CharacterConfig Config => _config;
        public View View => _view;

        private void Awake()
        {
            _input = new CharacterInput();
            _view = new View(_animator);
            _controller = GetComponent<CharacterController>();
            _movement = new MovementState(this);
        }

        private void Update() => _movement.Update();

        private void OnEnable() => _input.Enable();

        private void OnDisable() => _input.Disable();
    }
}

