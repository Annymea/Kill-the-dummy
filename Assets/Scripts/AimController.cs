using UnityEngine;

public class AimController : MonoBehaviour
{
    public GameObject player;
    public GameObject pointer;

    private SpriteRenderer spriteRenderer;
    private Camera activeCamera;

    private PlayerMovementActions playerActions;
    private Vector3 aimPosition;

    private void Awake()
    {
        playerActions = new PlayerMovementActions();
        spriteRenderer = GetComponent<SpriteRenderer>();
        activeCamera = Camera.main;
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
        aimPosition = activeCamera.ScreenToWorldPoint(new Vector3(worldPos.x, worldPos.y, activeCamera.nearClipPlane));
        aimPosition.y = aimPosition.y - spriteRenderer.size.y;
        Debug.Log(spriteRenderer.size);
    }

    private void FixedUpdate()
    {
        transform.position = aimPosition;

        MoveToMouse();
    }

    private void MoveToMouse()
    {
        Vector2 playerPos = player.transform.position;
        Vector2 direction = new Vector2(aimPosition.x - playerPos.x, aimPosition.y - playerPos.y);

        transform.up = direction;
    }

}
