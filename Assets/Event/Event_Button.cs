using UnityEngine;

public class Event_Button : MonoBehaviour
{
    public void OnButtonClick()
    {
        if (null == Event_EventManager._buttonClickedEvent)
        {
            Debug.LogError("Event_EventManager._buttonClickedEvent is null.");
            return;
        }

        Event_EventManager._buttonClickedEvent.Invoke();
    }
}
