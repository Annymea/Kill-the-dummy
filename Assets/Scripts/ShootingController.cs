using UnityEngine;

public class ShootingController : MonoBehaviour
{
    private PlayerMovementActions playerActions;
    private float isShooting;
    public ParticleSystem fire;

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
                Debug.Log("Start");
            }
        }
        else
        {
            if (fire.isPlaying)
            {
                fire.Stop();
                Debug.Log("Stop");
            }
        }
    }
}
