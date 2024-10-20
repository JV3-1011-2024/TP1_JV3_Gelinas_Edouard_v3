using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LightSwitchScript : MonoBehaviour
{
    public Light roomLight;
    public AudioClip switchSound;
    private AudioSource audioSource;
    private bool isLightOn = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        roomLight.enabled = isLightOn;
    }

    public void ToggleLight()
    {
        isLightOn = !isLightOn;
        roomLight.enabled = isLightOn;

       
        if (audioSource != null && switchSound != null)
        {
            audioSource.PlayOneShot(switchSound);
        }
    }
}
