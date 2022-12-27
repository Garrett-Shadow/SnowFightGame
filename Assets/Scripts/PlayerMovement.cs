using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Transform gun;
    [SerializeField] private Transform point;
    [SerializeField] private GameObject projectile;
    [SerializeField] private float speed = 50f;

    private float x = 0;
    private float y = 0;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var newSnowBall = Instantiate(projectile, point.position, Quaternion.identity);
            var rb = newSnowBall.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(point.forward * speed, ForceMode.VelocityChange);
            }
        }
        x += Input.GetAxis("Mouse X");
        y += Input.GetAxis("Mouse Y") * -1;
        transform.localRotation = Quaternion.Euler(0, x, 0);
        gun.localRotation = Quaternion.Euler(y, 270, 90);
    }
}
