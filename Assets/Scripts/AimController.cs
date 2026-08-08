using UnityEngine;

public class RotateAimCircle : MonoBehaviour
{
    public Sprite notHit;
    public Sprite hit;
    public SpriteRenderer spriteRenderer;
    public GameObject pointer;

    private Camera cam;

    private PlayerMovementActions playerActions;
    private Vector3 aimPosition;

    private void Awake()
    {
        playerActions = new PlayerMovementActions();
        cam = Camera.main;
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
        Vector2 worldPos = playerActions.Fight.Aim.ReadValue<Vector2>();

        aimPosition = cam.ScreenToWorldPoint(
            new Vector3(worldPos.x, worldPos.y, cam.nearClipPlane)
            );
    }

    private void FixedUpdate()
    {
        Vector2 playerPos = gameObject.transform.position;
        Vector2 direction = new Vector2(aimPosition.x - playerPos.x, aimPosition.y - playerPos.y);

        transform.up = direction;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        spriteRenderer.sprite = hit;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        spriteRenderer.sprite = notHit;
    }

}
