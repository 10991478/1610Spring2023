using UnityEngine;
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
}
