using UnityEngine;
[CreateAssetMenu]

/*ArrayObj is a ScriptableObject that allows you to store an int array and a string array

FUNCTION KEY:
    setItem(int pos, int num)
        sets the value of the item in intArray at a given index to a new value
    setItem(int pos, string str)
        sets the value of the item in stringArray at a given index to a new value
    getInt(int pos)
        gets the value of an item in intArray at a given index
    getString(int pos)
        gets the value of an item in stringArray at a given index
    getIntArrayLength()
        gets the length of intArray
    getStringArrayLength() 
        gets the length of stringArray
    insert(int pos, string str, int num)
        sets the values of the items in intArray and stringArray at a given index to a new value and pushes all other items after that index back
*/
public class ArrayObj : ScriptableObject
{
    public int[] intArray;
    public string[] stringArray;

//setItem() functions allow you to set an item in the int and string arrays by index
    public void setItem(int pos, int num)
    {
        intArray[pos] = num;
    }
    public void setItem(int pos, string str)
    {
        stringArray[pos] = str;
    }

//getInt() and getString() functions return an item in their respective arrays by index
    public int getInt(int pos)
    {
        return intArray[pos];
    }
    public string getString(int pos)
    {
        return stringArray[pos];
    }

//getIntArrayLength() and getStringArrayLength() functions return the length of their respective arrays
    public int getIntArrayLength()
    {
        return intArray.Length;
    }
    public int getStringArrayLength()
    {
        return stringArray.Length;
    }



/*insert() allows you to insert a string and an int into the arrays by index, pushing all values below the given index down

HERES HOW IT WORKS:
    1. insert() has three parameters: an int named pos, a string named str, and an int named num
        a. pos is the index at which you'd like to insert your info
        b. str is the string you'd like inserted into the stringArray array
        c. num is the int you'd like inserted into the intArray array
    2. Starting with the last item in the arrays, and going up unitl the items at index pos - 1:
        Each item is set to the value of the item at its index + 1 (this is what "pushes" the values down)
    3. The int item and string item at index pos in their respective arrays is set to str for the string item, and num for the int item*/
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
