using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    // Start is called before the first frame update
    private float nextSpawnTime;
    [SerializeField]
    private GameObject cubePrefab;
    [SerializeField]
    private float spawnDelay = 2;


    // Update is called once per frame
    private void Update()
    {
        if(ShouldSpawn())
		{
            Spawn();
		}
    }
    
    private void Spawn()
    {
        nextSpawnTime = Time.time + spawnDelay;
        Instantiate(cubePrefab, transform.position, transform.rotation);
    }

    private bool ShouldSpawn()
	{
        return Time.time >= nextSpawnTime;
	}
}
