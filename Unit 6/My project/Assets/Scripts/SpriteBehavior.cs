using UnityEngine;
[RequireComponent(typeof(SpriteRenderer))]
public class SpriteBehavior : MonoBehaviour
{
    private SpriteRenderer rendererObj;
    private void Start()
    {
        rendererObj = GetComponent<SpriteRenderer>();
    }

    public void ChangeRendererColor()
    {
        ColorID obj;
        if (GetComponent<IDContainerBehavior>().idObj.GetType() != typeof(ColorID))
        {
            return;
        }
        obj = (ColorID)GetComponent<IDContainerBehavior>().idObj;
        rendererObj.color = obj.value;
    }
}