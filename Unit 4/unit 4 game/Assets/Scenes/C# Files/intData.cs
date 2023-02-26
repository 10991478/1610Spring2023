using UnityEngine;

[CreateAssetMenu]

public class intData : ScriptableObject
{
    public int value;

    public void addToValue(int num){
        value += num;
    }

    public void setValue(int num){
        value = num;
    }
}
