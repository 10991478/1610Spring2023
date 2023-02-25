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
        if (value != limit){
            value += num;
            if (value > limit){
                value = limit;
            }
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
