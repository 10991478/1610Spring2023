using UnityEngine;

[CreateAssetMenu]

public class floatData : ScriptableObject
{
    public float value;
    public bool hasLimit;
    public bool hasMinimum;
    public float limit;
    public float minimum;
    public float decayRate;
    public void addToValue(float num){
        if (value + num > limit){
            if (!hasLimit){
                value += num;
            }
        }
        else{
            value += num;
        }
    }

    public void decay(){
        if (value - decayRate < minimum){
            if (!hasMinimum){
                value -= decayRate;
            }
        }
        else {
            value -= decayRate;
        }
    }
}
