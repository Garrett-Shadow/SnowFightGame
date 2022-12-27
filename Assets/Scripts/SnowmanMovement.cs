using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class SnowmanMovement : MonoBehaviour
{
    [SerializeField] private float MovementSpeed = 5f;
    private int health = 100;

    void Update()
    {
        transform.Translate(transform.forward * MovementSpeed * Time.deltaTime);
    }

    public void Damage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
