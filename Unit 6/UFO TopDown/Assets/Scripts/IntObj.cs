using UnityEngine;
[CreateAssetMenu]


/* IntObj is a ScriptableObject used for storing integer values with some built in functions

FUNCTION KEY:
    setValue(int newVal) -- sets the value of the IntObj to newVal
    addValue(int addVal) -- adds addVal to the IntObj's value if it doesn't exceed any restrictions on value
*/
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

/* addValue(int addVal) adds addVal to value
        int upperBound and int lowerBound are defined at the beginning
        bool hasUpperBound and bool hasLowerBound can be set to true or false if you want the IntObj to have boundaries on how high or low the value can be
        if upperBound applies and value + addVal > upperBound, then value will be set to upperBound, otherwise value += addVal
        if lpperBound applies and value + addVal < lpperBound, then value will be set to lpperBound, otherwise value += addVal*/
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
