using UnityEngine;

public class ColorIDBehavior : IDContainerBehavior
{
    public ColorIDObjList colorIDObjList;

    private void Awake()
    {
        idObj = colorIDObjList.currentColor;
    }
}
