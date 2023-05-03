using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script is for detecting collisions -- it is mainly used for detecting collisions between the lazers and the UFOs
public class DetectCollision : MonoBehaviour
{
    public bool affectsScore; //tells you whether or not to add to the score when collision is detected
    public int scoreToGive; //number added to the score if affectsScore is true
    private ScoreManager scoreManager; //stores reference to scoremanager
    public GameObject[] doDetect; //list of objects to detect collisions with
    public AudioClip clip;
    private SoundtrackManager soundtrackManager;

    void Start(){
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); //finds ScoreManager GameObject to reference its ScoreManager script component
        soundtrackManager = GameObject.Find("SoundtrackManager").GetComponent<SoundtrackManager>();
    }
    void OnTriggerEnter(Collider other)
    {
        bool detect = false; //tells you whether or not to detect the collision
        foreach (GameObject item in doDetect){
            if (other.gameObject.name == item.name + "(Clone)" || other.gameObject.name == item.name) //sets detect to true if the other object is a clone of any gameObjects in the doDetect list
            {
                detect = true;
                break;
            };
        }


        if (detect) //destroys both objects involved in collision if the other is on the list of objects to destroy
        {
            soundtrackManager.PlaySound(clip,1f);
            if (affectsScore) //adds to score if affectsScore is true
            {
                scoreManager.IncreaseScore(scoreToGive);
            }
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
