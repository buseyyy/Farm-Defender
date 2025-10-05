using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Array")]
    [SerializeField] GameObject[] animalPrefabs;

    [Space]

    [Header("Values")]
    [SerializeField] float spawnX = 23;
    [SerializeField] float spawnZ = 40;
    [SerializeField] float startDelay, spawnInterval = 2.0f;


    private void Start()
    {
        InvokeRepeating("SpawnerAnimal", startDelay, spawnInterval);
    }

    void SpawnerAnimal()
    {
        int animalArrayIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 animalSpawnPosition = new Vector3(Random.Range(-spawnX, spawnX), 0, spawnZ);
        Instantiate(animalPrefabs[animalArrayIndex], animalSpawnPosition, animalPrefabs[animalArrayIndex].transform.rotation);
    }

}
