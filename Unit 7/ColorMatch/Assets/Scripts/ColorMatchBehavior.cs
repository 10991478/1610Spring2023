using UnityEngine;

public class ColorMatchBehavior : MatchBehavior
{
    public ColorIDObjList colorIdObjList;

    private void Awake()
    {
        idObj = colorIdObjList.currentColor;
    }

    public void ChangeColor(SpriteRenderer renderer)
    {
        var newColor = (ColorID)idObj;
        renderer.color = newColor.value;
    }
}
