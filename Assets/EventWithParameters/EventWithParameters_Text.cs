using UnityEngine;
using UnityEngine.UI;

public class EventWithParameters_Text : MonoBehaviour
{
    private void Start()
    {
        if (null == EventWithParameters_EventManager.EventWithParameters)
        {
            Debug.LogError("EventWithParameters_EventManager.EventWithParameters is null.");
            return;
        }

        EventWithParameters_EventManager.EventWithParameters.AddListener(UpdateText);
    }

    private void OnDestroy()
    {
        if (null == EventWithParameters_EventManager.EventWithParameters)
        {
            Debug.LogError("EventWithParameters_EventManager.EventWithParameters is null.");
            return;
        }

        EventWithParameters_EventManager.EventWithParameters.RemoveListener(UpdateText);
    }

    private void UpdateText(string string1, string string2)
    {
        Text textComponent = gameObject.GetComponent<Text>();
        if (null == textComponent)
        {
            Debug.LogError("textComponent is null.");
        }

        textComponent.text = string1 + "\n" + string2;
    }
}
