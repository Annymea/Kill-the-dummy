using UnityEngine;

public class ShootingController : MonoBehaviour
{
    private PlayerMovementActions playerActions;
    private float isShooting;
    public ParticleSystem fire;


    public bool IsShooting()
    {
        return isShooting != 0;
    }

    private void Awake()
    {
        playerActions = new PlayerMovementActions();
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
        isShooting = playerActions.Fight.Shoot.ReadValue<float>();
    }

    private void FixedUpdate()
    {
        if (isShooting != 0)
        {
            if (!fire.isPlaying)
            {
                fire.Play();
            }
        }
        else
        {
            if (fire.isPlaying)
            {
                fire.Stop();
            }
        }
    }
}
