using UnityEngine;
using UnityEngine.InputSystem;

namespace Assets.Scripts.Character
{
    [RequireComponent(typeof(CharacterController))]
    public class Character : MonoBehaviour
    {
        [SerializeField] private CharacterConfig _config;

        private CharacterInput _input;
        private CharacterController _controller;

        private Vector2 _direction;
        private InputAction InputMove => _input.Gameplay.Move;

        private void Awake()
        {
            _input = new CharacterInput();
            _controller = GetComponent<CharacterController>();
        }

        private void Update()
        {
           _controller.Move(_direction.normalized * (_config.Speed * Time.deltaTime));
            Flip();
        }

       private void Flip() => transform.rotation = (_direction.x > 0) ? (GetQuaternionRight): (GetQuaternionLeft);

       private void GetDirectionInput(InputAction.CallbackContext context) => _direction = context.ReadValue<Vector2>();

       private Quaternion GetQuaternionLeft => Quaternion.Euler(0, 0, 0);

       private Quaternion GetQuaternionRight => Quaternion.Euler(0, 180, 0);

       private void OnEnable()
       {
            _input.Enable();
            InputMove.performed += GetDirectionInput;
       }

       private void OnDisable()
       {
            InputMove.performed -= GetDirectionInput;
            _input.Disable();
       }

    }
}

