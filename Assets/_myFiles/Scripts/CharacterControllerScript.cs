using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private float playerSpeed;


    PlayerInput playerInput;
    InputAction moveAction;



    private void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        moveAction = playerInput.actions.FindAction("Movement");

    }
        private void Update()
        {
            Move();

        }

        private void Move()
        {
            Vector2 direction = moveAction.ReadValue<Vector2>();
            transform.position += new Vector3(direction.x, 0, direction.y) * playerSpeed * Time.deltaTime;
        }

    
}