using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[RequireComponent(typeof(Text))]

public class TextLabelBehavior : MonoBehaviour
{
    private Text label;
    public bool roundToInt;
    public UnityEvent startEvent;
    public UnityEvent disableEvent;

    private void Start(){
        label = GetComponent<Text>();
        startEvent.Invoke();
    }

    public void UpdateLabel(floatObj dataObj){
        if (roundToInt){
            int displayVal = (int)dataObj.value;
            label.text = displayVal.ToString(CultureInfo.InvariantCulture);
        }
        else {
            label.text = dataObj.value.ToString(CultureInfo.InvariantCulture);
        }
    }

    public void UpdateLabel(intObj dataObj){
        label.text = dataObj.value.ToString(CultureInfo.InvariantCulture);
    }
    
    void OnDisable()
    {
        disableEvent.Invoke();
    }
}
