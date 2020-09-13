using UnityEngine;

public class EventButton : MonoBehaviour
{
    public void OnButtonClick()
    {
        if (null != EventManager._buttonClickedEvent)
        {
            EventManager._buttonClickedEvent.Invoke();
        }
    }
}
