using UnityEngine;

public class ColorIDBehavior : IDContainerBehavior
{
    public ColorIDObjList colorIDObjList;

    private void Awake()
    {
        SetColorID();
    }

    public void SetColorID()
    {
        idObj = colorIDObjList.currentColor;
    }
}
