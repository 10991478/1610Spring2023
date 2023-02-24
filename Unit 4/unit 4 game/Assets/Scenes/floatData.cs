using UnityEngine;

[CreateAssetMenu]

public class floatData : ScriptableObject
{
    public float value;
    public void addToValue(float num){
        value += num;
    }
}
