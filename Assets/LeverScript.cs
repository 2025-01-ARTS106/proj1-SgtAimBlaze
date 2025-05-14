using UnityEngine;
using System.Collections.Generic;

public class RandomSpawner : MonoBehaviour
{
    public GameObject objectToSpawn; // The prefab to spawn
    public int numberToSpawn = 3;    // How many instances to spawn
    public List<Transform> spawnPoints = new List<Transform>(); // Assign in inspector

    void Start()
    {
        SpawnRandomObjects();
    }

    void SpawnRandomObjects()
    {
        // Copy the list so we can remove from it without affecting the original
        List<Transform> availableSpawns = new List<Transform>(spawnPoints);

        for (int i = 0; i < numberToSpawn; i++)
        {
            if (availableSpawns.Count == 0) break;

            int randomIndex = Random.Range(0, availableSpawns.Count);
            Transform spawnPoint = availableSpawns[randomIndex];

            Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);
            availableSpawns.RemoveAt(randomIndex); // Avoid using same point twice
        }
    }
}