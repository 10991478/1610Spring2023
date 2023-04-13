using UnityEngine;
[RequireComponent(typeof(SpriteRenderer))]
public class SpriteBehavior : MonoBehaviour
{
    private SpriteRenderer rendererObj;
    private void Awake()
    {
        rendererObj = GetComponent<SpriteRenderer>();
    }

    public void ChangeRendererColor()
    {
        if (GetComponent<IDContainerBehavior>().idObj.GetType() != typeof(ColorID))
        {
            return;
        }
        ColorID obj = (ColorID)GetComponent<IDContainerBehavior>().idObj;
        rendererObj.color = obj.value;
    }
    public void ChangeRendererColor(ColorID obj)
    {
        rendererObj.color = obj.value;
    }

    public void ChangeRendererColor(ColorIDObjList obj)
    {
        rendererObj.color = obj.currentColor.value;
    }

    public void SetRendererWhite()
    {
        rendererObj.color = Color.white;
    }
}