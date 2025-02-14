using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Public variables
    [SerializeField] GameObject enemy;
    [SerializeField] float timeBetweenSpawns;

    // Private variables
    float elapsedSinceLastSpawn = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (elapsedSinceLastSpawn >= timeBetweenSpawns)
        {
            Instantiate(enemy, new Vector3(Random.Range(-8, 8), 5, 0), Quaternion.identity);
            elapsedSinceLastSpawn = 0;
        }
        elapsedSinceLastSpawn += Time.deltaTime;
    }
}
