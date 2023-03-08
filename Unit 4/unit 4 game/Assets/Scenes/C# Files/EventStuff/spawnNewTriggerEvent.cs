using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class spawnNewTriggerEvent : MonoBehaviour
{
    public int spawnNum;
    public GameObject spawnObj;
    public Transform spawnPos;
    public bool randomPos;
    public float spwanHeight;
    public float spawnRange;


    public void spawnNew(){
        for (int i = 0; i < spawnNum; i++){
            if (!randomPos){
                GameObject newSpawn = Instantiate(spawnObj, spawnPos.position, spawnPos.rotation);
                newSpawn.SetActive(true);
            }
            else {
                System.Random rand = new System.Random();

                GameObject newSpawn = Instantiate(spawnObj, new Vector3((float)(rand.NextDouble() * (spawnRange*2) - spawnRange),spwanHeight,(float)(rand.NextDouble() * (spawnRange*2) - spawnRange)), Quaternion.identity);
                newSpawn.SetActive(true);
            }
        }
    }
}
