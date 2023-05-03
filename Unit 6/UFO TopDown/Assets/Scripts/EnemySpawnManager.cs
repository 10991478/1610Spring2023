using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script manages the enemy spawning. It spawns enemies in at an increasing rate as the game goes on in order to make it more difficult
public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] ufoPrefabs; //Array to store UFO ships
    private float spawnRangeX = 20f;
    private float spawnPosZ = 15f;
    private float L = 1f;
    private float k; //set in Start()
    private float h = 1.25f;
    private float m = 60f;
    private float timeBetweenSpawns; //this is the output of LogisticFunction()
    private float timeOfLastSpawn;


    void Start()
    {
        timeOfLastSpawn = Time.time + 3f; //there's a bit of a delay at the beginning before the first ufo is spawned
        k = -8f/m; 
/*WHY IS K SET TO -8/m?
    The reason why k is set to -8/m is so that if I want to change m (the midway point of the curve),
    the steepness of the curve will change with it, making the output when x = 0 always be the same number (it's a number very, very, very close to L + h), no matter what m is set to.
    This is ideal because then we always get to start with a value that basically is the same as the top of the function, L + h
        P.S. Sidenote, I figured out how to do this by messing around on desmos for about three minutes. Setting k to -8/m will always work even if L, h, and m are all set to different values.
            P.P.S This trick works to anchor a value at 0 with any number, not just 8 for k = -8/m.
            I just picked 8 because it's a good number for f(0) to be very very close to L + h.
            Heres why the trick always works:
                1. When x = 0, (-k(x-m)) = (-k(0-m)) = (-k(-m)) = k*m
                2. If k = p/m, where p is just any real number, the k*m = (p/m)*m = (p)m/m = p(1) = p
                3. This means that (-k(x-m)) would always just equal p, no matter what m is as long as x=0 and k = p/m (p being any real number).
                4. This makes f(0) = L/(1+e^(-k(x-m)))+h = L/(1+e^p)+h, so the output at 0 is now entirely dependent on L, h, and p, effectively anchoring the output for when x = 0 by not changing when m is changed
*/
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
