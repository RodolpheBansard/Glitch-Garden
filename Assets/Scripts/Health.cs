using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int health = 100;
    [SerializeField] ParticleSystem deathVfx;

    public void DealDamage(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            PlayDeathVfx();
            Destroy(gameObject);
        }
    }

    public void PlayDeathVfx()
    {
        Instantiate(deathVfx, transform.position, transform.rotation);
    }
}
