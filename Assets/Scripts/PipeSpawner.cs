using UnityEngine;
using System.Collections;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] GameObject pipePairPrefab;  // Drag your PipePair prefab here
    [SerializeField] float spawnRate = 2f;
    [SerializeField] float heightOffset = 2.5f;

    void Start()
    {
        StartCoroutine(SpawnPipes());
    }

    IEnumerator SpawnPipes()
    {
        while (true)
        {
            float randomY = Random.Range(-heightOffset, heightOffset);
            Instantiate(pipePairPrefab, new Vector3(10f, randomY, 0), Quaternion.identity);
            yield return new WaitForSeconds(spawnRate);
        }
    }
}