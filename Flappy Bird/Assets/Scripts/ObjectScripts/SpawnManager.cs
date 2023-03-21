using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject [] obstaclePrefab;
    private Vector3 spawnPos = new Vector3(0, 0.286f,1.5f);
    public float startDelay = 2.0f;
    public float repeatRate = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstable", startDelay, repeatRate);    
    }

    private void SpawnObstable()
    {
        int obstacleIndex = Random.Range(0, obstaclePrefab.Length);
        if(true)
        {
            Instantiate(obstaclePrefab[obstacleIndex], spawnPos, obstaclePrefab[obstacleIndex].transform.rotation);
        }
    }
}
