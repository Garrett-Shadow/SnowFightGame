using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    private int damage = 45;

    private void OnCollisionEnter(Collision collision)
    {
        var snowMan = collision.gameObject.GetComponent<SnowmanMovement>();
        if (snowMan != null)
        {
            snowMan.Damage(damage);
        }
        Destroy(gameObject);
    }
}
