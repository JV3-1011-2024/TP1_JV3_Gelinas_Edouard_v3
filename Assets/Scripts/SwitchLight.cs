using UnityEngine;

public class SwitchLight : MonoBehaviour
{
    public Light roomLight;
    public AudioClip switchSound;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        roomLight.enabled = false;
    }

    void OnMouseDown()
    {
        roomLight.enabled = !roomLight.enabled;
        PlaySwitchSound();
    }

    void PlaySwitchSound()
    {
        if (audioSource && switchSound)
        {
            audioSource.PlayOneShot(switchSound);
        }
    }
}
