using UnityEngine;
using System.Collections;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] GameObject pipePrefab;  // Assign top+bottom pipe pair prefab
    [SerializeField] float spawnRate = 2f;
    [SerializeField] float heightOffset = 2f;
    [SerializeField] float speed = 3f;

    void Start() { StartCoroutine(SpawnPipes()); }

    IEnumerator SpawnPipes()
    {
        while (true)
        {
            float randomY = Random.Range(-heightOffset, heightOffset);
            Vector3 spawnPos = new(10f, randomY, 0);  // Off-screen right
            GameObject pipes = Instantiate(pipePrefab, spawnPos, Quaternion.identity);
            pipes.GetComponent<PipeMover>().speed = speed;  // Tweak speed
            yield return new WaitForSeconds(spawnRate);
        }
    }
}