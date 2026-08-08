using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject shootingObject;
    private ShootingController shootingLogic;

    private void Awake()
    {
        shootingLogic = shootingObject.GetComponent<ShootingController>();
    }


    public bool IsPlayerShooting()
    {
        return shootingLogic.IsShooting();
    }
}
