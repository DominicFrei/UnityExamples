using UnityEngine;
using UnityEngine.UI;

public class EventText : MonoBehaviour
{
    private void Start()
    {
        if (null != EventManager._buttonClickedEvent)
        {
            EventManager._buttonClickedEvent.AddListener(UpdateText);
        }
    }

    private void OnDestroy()
    {
        if (null != EventManager._buttonClickedEvent)
        {
            EventManager._buttonClickedEvent.RemoveListener(UpdateText);
        }
    }

    private void UpdateText()
    {
        gameObject.GetComponent<Text>().text = Random.Range(0, 100) + "";
    }    
}
