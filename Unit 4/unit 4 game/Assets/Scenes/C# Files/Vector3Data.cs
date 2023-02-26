using UnityEngine;

[CreateAssetMenu]

public class Vector3Data : ScriptableObject
{
    public float x;
    public float y;
    public float z;

    public Vector3 returnVector3(){
        return new Vector3(x,y,z);
    }
}
