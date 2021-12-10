using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerHealthBar : MonoBehaviour
{
    public HealthBarScript healthBar;
    float hitPoints = 100;

    public void ReceiveDamage(float damage)
    {
        if(healthBar != null)
        {
            hitPoints -= damage;
            healthBar.SetHealth(hitPoints);
            if(hitPoints <= 0)
            {

            }
        }
    }
}