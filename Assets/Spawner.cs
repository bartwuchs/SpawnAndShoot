using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    public GameObject Prefab;
    

    // Update is called once per frame
    void Update()
    {
        Move();
        if (Input.GetKeyDown(KeyCode.Space))
            SpawnMany(10);
    }
    private void SpawnMany(int n)
    {
        Vector3 pos = transform.position;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if(ShouldSpawn())
                    SpawnOne(pos);
                pos.x += 1;
            }
            pos.x = transform.position.x;
            pos.y += 1;
        }
    }
    public float FillValue = 0.9f;

    private bool ShouldSpawn()
    {
        return Random.value <  FillValue;
    }

    private void SpawnOne(Vector3 pos)
    {
        Instantiate(Prefab, pos, Quaternion.identity);
    }
    private void SpawnOne()
    {
        Instantiate(Prefab, transform.position, Quaternion.identity);
    }

    private void Move()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time) * 5, 0, 0);
    }
}
