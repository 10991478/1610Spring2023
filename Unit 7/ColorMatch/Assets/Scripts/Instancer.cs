using UnityEngine;
[CreateAssetMenu]

public class Instancer : ScriptableObject
{
    public GameObject prefab;
    public GameObject prefabChild;
    private int num = 0;

    public void CreateInstance()
    {
        Instantiate(prefab);
    }

    public void CreateInstance(Vector3Obj obj)
    {
        Instantiate(prefab, obj.value, Quaternion.identity);
    }

    public void CreateInstanceFromList(Vector3ObjList obj)
    {
        for (int i = 0; i < obj.vector3ObjList.Count; i++)
        {
            Instantiate(prefab, obj.vector3ObjList[i].value, Quaternion.identity);
        }
    }

    public void CreateInstanceFromListCounting(Vector3ObjList obj)
    {
        Instantiate(prefab, obj.vector3ObjList[num].value, Quaternion.identity);
        num++;
        if (num == obj.vector3ObjList.Count)
        {
            num = 0;
        }
    }

    public void CreateInstanceFromListRandomly(Vector3ObjList obj)
    {
        num = Random.Range(0,obj.vector3ObjList.Count);
        Instantiate(prefab, obj.vector3ObjList[num].value, Quaternion.identity);
    }
    public void CreateInstanceAndChildFromListRandomly(Vector3ObjList obj)
    {
        num = Random.Range(0,obj.vector3ObjList.Count);
        Instantiate(prefab, obj.vector3ObjList[num].value, Quaternion.identity);
        Instantiate(prefabChild, obj.vector3ObjList[num].value, Quaternion.identity);
    }
}
