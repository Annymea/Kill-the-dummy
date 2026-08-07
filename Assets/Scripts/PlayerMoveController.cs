using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    public Rigidbody2D body; 

    private PlayerMovementActions playerActions;
    private SpriteRenderer spriteRenderer;
    private Vector2 movement;


    private void Awake()
    {
        playerActions = new PlayerMovementActions();
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
        //only move if there is nothing in the way
        body.linearVelocity = new Vector2(movement.x * moveSpeed, movement.y * moveSpeed);
        //gameObject.transform.position = transform.position + new Vector3(movement.x * moveSpeed * Time.deltaTime, movement.y * moveSpeed * Time.deltaTime, 0);
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Aua");
    }
}
