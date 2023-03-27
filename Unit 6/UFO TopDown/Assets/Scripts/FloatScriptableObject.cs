using UnityEngine;
[CreateAssetMenu]

public class FloatScriptableObject : ScriptableObject
{
    public float value;
    public bool hasUpperBound;
    public bool hasLowerBound;
    public float lowerBound;
    public float upperBound;

    public void setValue(float newVal){
        value = newVal;
    }

    //adds to the value
    /*WHEN ADDING:
        1: If not constrained, add to value
        2: If constrained:
            a: If added value would exceed either upper or lower bound, set value to exceeded bound
            b: If doesn't exceed bounds, add to value*/
    public void addValue(float addVal){
        if (hasLowerBound || hasLowerBound)
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
            if (hasLowerBound){
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
        else{
            value += addVal;
        }
    }
}
