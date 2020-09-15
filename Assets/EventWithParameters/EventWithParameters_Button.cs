using UnityEngine;
using UnityEngine.UI;

public class EventWithParameters_Button : MonoBehaviour
{
    [SerializeField] private Text _text1 = null;
    [SerializeField] private Text _text2 = null;

    public void OnClick()
    {
        if (null == _text1 || null == _text2)
        {
            Debug.LogError("At least one of the attached Text objects is null.");
            return;
        }
        if (null == EventWithParameters_EventManager.EventWithParameters)
        {
            Debug.LogError("EventWithParameters_EventManager.EventWithParameters is null.");
            return;
        }

        string string1 = _text1.text;
        string string2 = _text2.text;
        EventWithParameters_EventManager.EventWithParameters.Invoke(string1, string2);
    }
}
