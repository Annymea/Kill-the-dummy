using System;
using UnityEngine;

public class DummyController : MonoBehaviour
{
    
    [SerializeField] private int maxHealthPoints = 100;
    private int currentHealth = 100;
    [SerializeField] private float dmgFrequency = 1.0f;

    [SerializeField] private GameObject healthbar;
    [SerializeField] private GameObject player;
    private PlayerController playerController;
    float timePassed = 0f;
    private bool isAimedAt = false;

    private void Awake()
    {
        player = GameObject.Find("Player");
    }

    public void DoDamage(int damage)
    {
        if(isAimedAt && playerController.IsPlayerShooting())
        currentHealth -= damage;
        if(currentHealth < 0)
            currentHealth = 0;
        float HealthPercentage = (float)currentHealth / (float)maxHealthPoints;
        healthbar.transform.localScale = new Vector3(HealthPercentage, 1f);
    }

    private void Update()
    {
        if (playerController != null && playerController.IsPlayerShooting())
        {
            timePassed += Time.deltaTime;
                if (timePassed >= dmgFrequency)
                {
                    timePassed = 0f;
                    DoDamage(10);
            }
        }
        else
        {
            timePassed = 0f;
        }

        if(currentHealth == 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isAimedAt = true;
        playerController = player.GetComponent<PlayerController>();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isAimedAt = false;
    }

}
