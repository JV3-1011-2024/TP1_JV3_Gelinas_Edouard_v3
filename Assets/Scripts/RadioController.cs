using UnityEngine;

public class RadioController : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        
        audioSource = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
       
        if (audioSource.isPlaying)
        {
            StopMusic();
        }
        else
        {
            PlayMusic();
        }
    }

    
    void PlayMusic()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }

    
    void StopMusic()
    {
        if (audioSource != null)
        {
            audioSource.Stop();
        }
    }
}
