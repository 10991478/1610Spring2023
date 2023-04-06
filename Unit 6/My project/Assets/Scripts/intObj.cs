using UnityEngine;
using UnityEngine.Events;
[CreateAssetMenu]
public class intObj : ScriptableObject
{
    public int value;

    public void addVal(int num)
    {
        value += num;
    }

    public void setVal(int num)
    {
        value = num;
    }
    public void setVal(intObj obj)
    {
        value = obj.value;
    }

    public void compareVal(intObj obj)
    {
        if (obj.value > value)
        {
            value = obj.value;
        }
    }
}
