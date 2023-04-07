using UnityEngine;

[CreateAssetMenu]

public class FloatObj : ScriptableObject
{
    public float value;
    public bool hasLimit;
    public bool hasMinimum;
    public float limit;
    public float minimum;
    public float decayRate;
    public void AddToValue(float num){
        if (value != limit){
            value += num;
            if (value > limit){
                value = limit;
            }
        }
    }

    public void SetValue(float num){
        value = num;
    }

    public void Decay(){
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
