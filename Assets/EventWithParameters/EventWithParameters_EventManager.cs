using UnityEngine;
using UnityEngine.Events;

public class EventWithParameters_EventManager : MonoBehaviour
{
    public static UnityEvent<string, string> EventWithParameters = new UnityEvent<string, string>();
}
