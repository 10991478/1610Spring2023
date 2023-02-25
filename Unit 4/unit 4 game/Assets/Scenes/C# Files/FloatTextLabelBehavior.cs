using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]

public class FloatTextLabelBehavior : MonoBehaviour
{
    public Text label;
    public floatData dataObj;
    public bool roundToInt;

    private void Start(){
        label = GetComponent<Text>();
        UpdateLabel();
    }

    public void UpdateLabel(){
        if (roundToInt){
            int displayVal = (int)dataObj.value;
            label.text = displayVal.ToString(CultureInfo.InvariantCulture);
        }
        else {
            label.text = dataObj.value.ToString(CultureInfo.InvariantCulture);
        }
    }
}
