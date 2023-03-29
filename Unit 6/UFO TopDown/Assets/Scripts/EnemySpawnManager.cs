using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] ufoPrefabs; //Array to store UFO ships
    private float spawnRangeX = 20f;
    private float spawnPosZ = 15f;
    private float L = 1f;
    private float k;
    private float h = 1.25f;
    private float m = 60f;
    private float timeBetweenSpawns; //this is the output of LogisticFunction()
    private float timeOfLastSpawn;


    void Start()
    {
        timeOfLastSpawn = Time.time - 3f; //there's a bit of a delay at the beginning before the first ufo is spawned
        k = -8f/m;
    }

    void Update()
    {
        timeBetweenSpawns = LogisticFunction((float)Time.time);
        if (Time.time - timeOfLastSpawn >= timeBetweenSpawns)
        {
            SpawnRandomUFO();
            timeOfLastSpawn = Time.time;
        }
    }

/*Instead of using InvokeRepeating() I'm using my own function, LogisticFunction(), to repeatedly call SpawnRandomUFO()
    I'm doing it this way so that the UFOs spawn increasingly quickly to make the game get harder as you go along
    I'm using a logistic function for this so that the spawn rate can increase gradually, then more quickly, then gradually, and then basically flatten out at a certain point
    Logistic functions look like this: f(x) = L/(1 + e^(-k(x-m))) + h
    Or this way is easier to read:

                    L
    f(x) =  _________________   +   h
                   (-k(x - m))
            1 + e

    L is the top where the function never quite reaches (-L is the bottom where it also never quite reaches)
    e is just the number e
    k is how steep the curve is
    x is the variable input into the function (in this case we'll be using Time.time for the input of x)
    m is the middle of the curve left/right
    h is the middle of the curve up/down
    L + h is actually the top, and -L + h is the bottom

    I'm going to have k be between 0 and -1 because
        1: Having k be negative will make the function go from high to low
            a: I want it to go from high to low because the output of the function is gonna be the time inbetween spawns, so smaller time means faster spawning
        2: Having k be less than 1 will make the curve much less steep, making the spawn rate go from high to low more gradually without a quick change in the middle
*/
    float LogisticFunction(float x)
    {
        float output;
        output = L/(1 + Mathf.Exp(-k*(x-m))) + h;
        return output;
    }

    void SpawnRandomUFO()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0,spawnPosZ);
        int ufoIndex = Random.Range(0,ufoPrefabs.Length); //Picks a random UFO from the array
        Instantiate(ufoPrefabs[ufoIndex], spawnPos, ufoPrefabs[ufoIndex].transform.rotation); //Spawn an indexed UFO from the array
    }
}
