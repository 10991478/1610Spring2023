using UnityEngine;
using UnityEngine.Events;
[CreateAssetMenu]
public class IntObj : ScriptableObject
{
    public int value;

    public void AddVal(int num)
    {
        value += num;
    }

    public void SetVal(int num)
    {
        value = num;
    }
    public void SetVal(IntObj obj)
    {
        value = obj.value;
    }

    public void CompareVal(IntObj obj)
    {
        if (obj.value > value)
        {
            value = obj.value;
        }
    }
}
