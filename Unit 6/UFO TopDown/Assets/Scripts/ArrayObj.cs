using UnityEngine;
[CreateAssetMenu]

public class ArrayObj : ScriptableObject
{
    public int[] intArray;
    public string[] stringArray;

    public void setItem(int pos, int num)
    {
        intArray[pos] = num;
    }
    public void setItem(int pos, string str)
    {
        stringArray[pos] = str;
    }

    public int getInt(int pos)
    {
        return intArray[pos];
    }
    public string getString(int pos)
    {
        return stringArray[pos];
    }
}
