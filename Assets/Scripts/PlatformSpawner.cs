using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
public GameObject platformPrefab;
    public float spawnInterval = 2f;
    public float minX = -2f;
    public float maxX = 0;
    public Transform cameraTransform;

    private float nextY;

    void Start() {
        nextY = cameraTransform.position.y + 5f;
        InvokeRepeating("SpawnPlatform", 1f, spawnInterval);
    }

    void SpawnPlatform() {
        float x = Random.Range(minX, maxX);
        Vector3 spawnPos = new Vector3(x, nextY, 0);
        Instantiate(platformPrefab, spawnPos, Quaternion.identity);
        nextY -= 2.5f; // distancia entre plataformas
    }
}
