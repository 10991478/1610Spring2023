using UnityEngine;

public class ColorMatchBehavior : MatchBehavior
{
    public void ChangeColor(SpriteRenderer renderer)
    {
        var newColor = (ColorID)idObj;
        renderer.color = newColor.value;
    }
}