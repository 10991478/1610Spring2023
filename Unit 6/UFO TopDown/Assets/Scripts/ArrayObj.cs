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

    public int getIntArrayLength()
    {
        return intArray.Length;
    }
    public int getStringArrayLength()
    {
        return stringArray.Length;
    }

    public void insert(int pos, string str, int num)
    {
        for (int i = intArray.Length - 1; i > pos; i--)
        {
            intArray[i] = intArray[i-1];
        }
        intArray[pos] = num;
        for (int i = stringArray.Length - 1; i > pos; i--)
        {
            stringArray[i] = stringArray[i-1];
        }
        stringArray[pos] = str;
    }
}
