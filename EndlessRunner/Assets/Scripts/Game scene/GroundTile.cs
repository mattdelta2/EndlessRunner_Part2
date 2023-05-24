using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{

    GroundSpawner groundSpawner;
    // Start is called before the first frame update
    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
        SpawnObsticle();
        
    }

    private void OnTriggerExit(Collider other)
    {
        groundSpawner.SpawnTile();
        Destroy(gameObject, 2);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public GameObject[] ObsticlePrefab;


    void SpawnObsticle()
    {
        int obsticleSpawnIndex = Random.Range(4, 6);

        Transform spawnPoint = transform.GetChild(obsticleSpawnIndex).transform;

        int obsticlePrefabIndex = Random.Range(0, 4);

        Instantiate(ObsticlePrefab[obsticlePrefabIndex], spawnPoint.position, Quaternion.identity, transform);
    }


}
