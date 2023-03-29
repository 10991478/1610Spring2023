using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawnManager : MonoBehaviour
{
    public GameObject[] pickupPrefabs; //Array to store pickups
    private float spawnRangeX = 20f;
    private float spawnPosZ = 20f;
    private float startDelay = 4f;
    private float spawnInterval = 3.5f;
    public IntObj boltCount;
    public FloatScriptableObject fireRate;
    private bool hasBoltBeenRemoved;
    private bool hasFireBeenRemoved;
    private List<GameObject> validPickups;

    void Start()
    {
        InvokeRepeating("SpawnRandomPickup", startDelay, spawnInterval);
        hasBoltBeenRemoved = false;
        hasFireBeenRemoved = false;
        validPickups = new List<GameObject>(pickupPrefabs);
    }

    void Update(){
        if (boltCount.value == boltCount.upperBound && !hasBoltBeenRemoved)
        {
            for (int i = 0; i < validPickups.Count; i++){
                if (validPickups[i].name == "BoltPickup")
                {
                    validPickups.RemoveAt(i);
                    break;
                }
            }
            hasBoltBeenRemoved = true;
        }
        if (fireRate.value == fireRate.lowerBound && !hasFireBeenRemoved)
        {
            for (int i = 0; i < validPickups.Count; i++){
                if (validPickups[i].name == "FireRatePickup")
                {
                    validPickups.RemoveAt(i);
                    break;
                }
            }
            hasFireBeenRemoved = true;
        }
    }


/*HOW SpawnRandomPickup() DETERMINES WHAT TO SPAWN
    1: pickupPrefabs[] is a Gamobject array containing all the pickup prefabs to potentially spawn
    2: validPickups is a list that starts with all the pickupPrefabs items in it
    3: If the bolt count ever reaches its max, it is removed from the validPickups list
    4: if the fire rate ever reaches its min, it is removed from the validPickups list
    5: SpawnRandomPickup randomly selects an item from the validPickups list and spawns it in at a random z position within range at the top of the screen*/
    void SpawnRandomPickup()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0,spawnPosZ);
        int pickupIndex = Random.Range(0,validPickups.Count); //Picks a random pickup from the validPickups list
        Instantiate(validPickups[pickupIndex], spawnPos, validPickups[pickupIndex].transform.rotation); //Spawns the randomly selected object to a random z position at the top of the screen
    }
}
