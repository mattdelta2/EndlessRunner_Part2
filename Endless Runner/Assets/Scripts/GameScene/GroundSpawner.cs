using UnityEngine;

public class GroundSpawner : MonoBehaviour
{



    public GameObject groundTile;
    Vector3 nextSpawnPoint;

    public void SpawnTile(bool spawnItems)
    {
       GameObject temp =  Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;


        if(spawnItems)
        {
            temp.GetComponent<GroundTile>().SpawnObsticle();

            temp.GetComponent<GroundTile>().spawnCoins();

            temp.GetComponent<GroundTile>().SpawnPowerUps();
        }
    }
    void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            if(i<3)
            {
                SpawnTile(false);
            }
            else
            SpawnTile(true);
        }
        
    }


}