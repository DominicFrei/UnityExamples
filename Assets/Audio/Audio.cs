using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField] private AudioClip _audioClip = null;

    void Start()
    {
        // Play the clip at a point.
        AudioSource.PlayClipAtPoint(_audioClip, new Vector3(1, 1, 1));
        StartCoroutine(PlayAudio());
    }

    private IEnumerator PlayAudio()
    {
        // Alternative: Play the AudioSource's attached AudioClip.
        while(true)
        {
            yield return new WaitForSeconds(2.0f);
            GetComponent<AudioSource>().Play();
        }
    }
}
