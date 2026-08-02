using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    
    private Rigidbody2D rigidBody;

    private PlayerMovementActions playerActions;
    private SpriteRenderer spriteRenderer;
    private Vector2 movement;
    private Vector2 aimTo;


    private void Awake()
    {
        playerActions = new PlayerMovementActions();
        rigidBody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnEnable()
    {
        playerActions.Enable();
    }

    private void OnDisable()
    {
        playerActions.Disable();
    }

    private void Update()
    {
        //Register Player Input
        movement = playerActions.Movement.Move.ReadValue<Vector2>();
        aimTo = playerActions.Fight.Aim.ReadValue<Vector2>();
        Debug.Log(aimTo);
    }

    private void FixedUpdate()
    {
        if (movement.x == -1)
        {
            spriteRenderer.flipX = true;
        }
        else if (movement.x > 0) { 
            spriteRenderer.flipX= false;
        }
        //Do the Physics
        gameObject.transform.position = transform.position + new Vector3(movement.x * moveSpeed * Time.deltaTime, movement.y * moveSpeed * Time.deltaTime, 0);
        
    }
}
