using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
    public static UnityEvent _buttonClickedEvent;

    private void Start()
    {
        if (null == _buttonClickedEvent)
        {
            _buttonClickedEvent = new UnityEvent();
        }
    }
}
