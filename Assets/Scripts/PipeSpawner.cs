using UnityEngine;
using System.Collections;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] GameObject pipePairPrefab;
    [SerializeField] float spawnRate = 2f;

    [SerializeField] float baseY = -5.5f;        // gap center
    [SerializeField] float randomOffset = 1.8f; // small variation so it's not boring
    [SerializeField] float xSpawnLocation = 13f; // off-screen right

    void Start()
    {
        StartCoroutine(SpawnPipes());
    }

    IEnumerator SpawnPipes()
    {
        while (true)
        {
            float finalY = baseY + Random.Range(-randomOffset, randomOffset);
            Instantiate(pipePairPrefab, new Vector3(xSpawnLocation, finalY, 0), Quaternion.identity);
            yield return new WaitForSeconds(spawnRate);
        }
    }
}