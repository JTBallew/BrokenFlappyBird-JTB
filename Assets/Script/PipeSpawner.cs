using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = .1f;
    public float heightVeriable = 1.5f;
    public Transform pipeSpawnPoint;
    
    private float timer = float.MaxValue;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnRate)
        {
            SpawnPipe();
            timer = 0f;
        }
    }

    public void StartSpawning()
    {
        enabled = true;
    }

    void SpawnPipe()
    {
        float yOffset = 0.5f + Random.Range(-heightVeriable, heightVeriable);
        Vector3 spawnPosition = pipeSpawnPoint.position + Vector3.up * yOffset;
        Instantiate(pipePrefab, spawnPosition, Quaternion.identity);
    }
}
