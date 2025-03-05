using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn; // Assign the prefab in Inspector
    public float spawnInterval = 2f; // Time between spawns
    public float spawnRangeX = 10f; // X-axis spawn range
    public float spawnRangeY = 5f;  // Y-axis spawn range

    void Start()
    {
        InvokeRepeating(nameof(SpawnObject), 0f, spawnInterval); // Repeats spawn function
    }

    void SpawnObject()
    {
        // Generate a random position
        Vector2 randomPosition = new Vector2(
    Random.Range(-spawnRangeX, spawnRangeX),
    transform.position.y // Keep Y fixed, only randomize X
);


        // Spawn the object at the random position
        Instantiate(objectToSpawn, randomPosition, Quaternion.identity);
    }
}

