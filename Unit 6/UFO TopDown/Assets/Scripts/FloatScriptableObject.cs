using UnityEngine;
[CreateAssetMenu]

/*This script is for making ScriptableObjects that store float values for them
    
FUNCTION KEY:
    setValue(float newVal) -- sets the value of the FloatScriptableObject to newVal
    addValue(float addVal) -- adds addVal to the FloatScriptableObject's value if it doesn't exceed any restrictions on value
*/
public class FloatScriptableObject : ScriptableObject
{
    public float value;
    public bool hasUpperBound;
    public bool hasLowerBound;
    public float lowerBound; //lower limit for value if hasLowerBound is true
    public float upperBound; //upper limit for value if hasUpperBound is true

    public void setValue(float newVal){
        value = newVal;
    }

    //addValue() adds to value
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
