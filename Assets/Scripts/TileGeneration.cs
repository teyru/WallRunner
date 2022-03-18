using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGeneration : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    private List<GameObject> activeTiles = new List<GameObject>();

    private float spawnPosition = 0;
    private float tileLength = 95;

    [SerializeField] private Transform player;
    private int startTilesCount = 4;


    void Start()
    {
        for (int i = 0; i<startTilesCount; i++)
        {
            SpawnTile(Random.Range(0, tilePrefabs.Length));
        }
    }
    

    void Update()
    {
        if(player.position.z - 180 > spawnPosition - (startTilesCount * tileLength))
        {
            SpawnTile(Random.Range(0, tilePrefabs.Length));
            DeleteTile();
        }

    }


    private void SpawnTile(int tileIndex)
    {
        GameObject nextTile = Instantiate(tilePrefabs[tileIndex], transform.forward * spawnPosition, transform.rotation);
        activeTiles.Add(nextTile);
        spawnPosition += tileLength;
    }

    private void DeleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }
}
