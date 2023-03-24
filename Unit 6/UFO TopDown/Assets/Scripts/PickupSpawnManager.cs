using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawnManager : MonoBehaviour
{
    public GameObject[] pickupPrefabs; //Array to store pickups
    private float spawnRangeX = 20f;
    private float spawnPosZ = 20f;
    private float startDelay = 6f;
    private float spawnInterval = 5f;


    void Start()
    {
        InvokeRepeating("SpawnRandomPickup", startDelay, spawnInterval);
    }

    void SpawnRandomPickup()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0,spawnPosZ);
        int pickupIndex = Random.Range(0,pickupPrefabs.Length); //Picks a random UFO from the array
        Instantiate(pickupPrefabs[pickupIndex], spawnPos, pickupPrefabs[pickupIndex].transform.rotation); //Spawn an indexed UFO from the array
    }
}
