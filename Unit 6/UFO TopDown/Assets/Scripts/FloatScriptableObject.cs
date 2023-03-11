using UnityEngine;
[CreateAssetMenu]

public class FloatScriptableObject : ScriptableObject
{
    public float value;

    public void setValue(float newVal){
        value = newVal;
    }
    public void addValue(float addVal){
        value += addVal;
    }
}
