using UnityEngine;

public class GroundTile : MonoBehaviour
{


    GroundSpawner groundSpawner;
    [SerializeField] GameObject tallObsticleSpawner;
    [SerializeField] float tallObsticleChance = .2f;
    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();

        SpawnObsticle();

        spawnCoins();
        SpawnPowerUps();
        
    }



    private void OnTriggerExit(Collider other)
    {
        groundSpawner.SpawnTile(true);
        Destroy(gameObject, 2);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject obsticlePrefab;

    public void SpawnObsticle()
    {
        GameObject obsticleToSpawn = obsticlePrefab;

        float random = Random.Range(0f, 1f);
            if(random<tallObsticleChance)
        {
            obsticleToSpawn = tallObsticleSpawner;
        }

        int randomSpawnIndex = Random.Range(6, 9);

        Transform spawnPoint = transform.GetChild(randomSpawnIndex);

        Instantiate(obsticleToSpawn, spawnPoint.position, Quaternion.identity, transform);

    }


    public GameObject coinPrefab;


    public void spawnCoins()
    {
        int coinToSpawn = 2;

        for (int i = 0; i < coinToSpawn; i++)
        {

            GameObject temp =  Instantiate(coinPrefab, transform);

            temp.transform.position = getRandomPointInCollider(GetComponent<Collider>());

            


        }
    }

    public GameObject[] PowerUps;


    public void SpawnPowerUps()
    {
        int PowerUpIndex = Random.Range(0, 2);
        int powerUpToSpawn = 1;

        for (int i = 0; i < powerUpToSpawn; i++)
        {
            GameObject temp = (Instantiate(PowerUps[PowerUpIndex], transform));

            temp.transform.position = getRandomPointInCollider(GetComponent<Collider>());

        }

    }

    Vector3 getRandomPointInCollider(Collider collider)
    {
        Vector3 point = new Vector3(
            Random.Range(collider.bounds.min.x, collider.bounds.max.x),
            Random.Range(collider.bounds.min.y, collider.bounds.max.y),
            Random.Range(collider.bounds.min.z, collider.bounds.max.z));

        if(point != collider.ClosestPoint(point))

        {
            point = getRandomPointInCollider(collider);
        }


        point.y = 1;

        return point;
    }


}
