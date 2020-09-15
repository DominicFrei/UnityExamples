using UnityEngine;
using UnityEngine.UI;

public class Event_Text : MonoBehaviour
{
    private void Start()
    {
        if (null == Event_EventManager._buttonClickedEvent)
        {
            Debug.LogError("Event_EventManager._buttonClickedEvent is null.");
            return;
        }

        Event_EventManager._buttonClickedEvent.AddListener(UpdateText);
    }

    private void OnDestroy()
    {
        if (null == Event_EventManager._buttonClickedEvent)
        {
            Debug.LogError("Event_EventManager._buttonClickedEvent is null.");
            return;
        }

        Event_EventManager._buttonClickedEvent.RemoveListener(UpdateText);
    }

    private void UpdateText()
    {
        Text textComponent = gameObject.GetComponent<Text>();
        if (null == textComponent)
        {
            Debug.LogError("textComponent is null.");
        }

        textComponent.text = Random.Range(0, 100) + "";
    }    
}
