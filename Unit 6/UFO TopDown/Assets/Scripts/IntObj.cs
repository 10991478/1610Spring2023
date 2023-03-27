using UnityEngine;
[CreateAssetMenu]

public class IntObj : ScriptableObject
{
    public int value;
    public int valueLimit;
    public bool hasLimit;

    public void setValue(int newVal){
        value = newVal;
    }
    public void addValue(int addVal){
        if (hasLimit)
        {
            if (value + addVal <= valueLimit)
            {
                value += addVal;
            }
            else
            {
                value = valueLimit;
            }
        }
        else
        {
            value += addVal;
        }
    }
}
