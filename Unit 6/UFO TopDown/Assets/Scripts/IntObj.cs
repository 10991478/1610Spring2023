using UnityEngine;
[CreateAssetMenu]

public class IntObj : ScriptableObject
{
    public int value;
    public bool hasUpperBound;
    public int upperBound;
    public bool hasLowerBound;
    public int lowerBound;


    public void setValue(int newVal){
        value = newVal;
    }
    public void addValue(int addVal){
        if (hasUpperBound || hasLowerBound)
        {
            if (hasUpperBound)
            {
                if (value + addVal > upperBound)
                {
                    value = upperBound;
                }
                else
                {
                    value += addVal;
                }
            }
            if (hasLowerBound)
            {
                if (value + addVal < lowerBound)
                {
                    value = lowerBound;
                }
                else
                {
                    value += addVal;
                }
            }
        }
        else
        {
            value += addVal;
        }
    }
}
