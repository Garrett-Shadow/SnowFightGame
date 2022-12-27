using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject Snowman;

    void Start()
    {
        StartCoroutine(spawn());
    }

    private IEnumerator spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            float x = Random.Range(-40, 40);
            float z = Random.Range(-80, -110);
            var newSnowMan = Instantiate(Snowman, new Vector3(x, 8.5f, z), Quaternion.Euler(0,0,90));
        }
    }
}
