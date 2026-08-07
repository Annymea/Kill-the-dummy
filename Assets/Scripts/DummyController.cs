using System;
using UnityEngine;

public class DummyController : MonoBehaviour
{
    [SerializeField] private int maxHealthPoints = 100;
    private int currentHealth = 100;

    [SerializeField] private GameObject healthbar;
    public void DoDamage(int damage)
    {
        currentHealth -= damage;
        healthbar.
    }
}
