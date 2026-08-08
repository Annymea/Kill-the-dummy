using System;
using UnityEngine;

public class DummyController : MonoBehaviour
{
    
    [SerializeField] private int maxHealthPoints = 100;
    private int currentHealth = 100;

    [SerializeField] private GameObject healthbar;
    [SerializeField] private GameObject player;
    private PlayerController playerController;

    public void DoDamage(int damage)
    {
        currentHealth -= damage;
        if(currentHealth < 0)
            currentHealth = 0;
        float HealthPercentage = (float)currentHealth / (float)maxHealthPoints;
        healthbar.transform.localScale = new Vector3(HealthPercentage, 1f);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerController = player.GetComponent<PlayerController>();

        if(playerController != null && playerController.IsPlayerShooting())
        {
            DoDamage(10);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        
    }
}
