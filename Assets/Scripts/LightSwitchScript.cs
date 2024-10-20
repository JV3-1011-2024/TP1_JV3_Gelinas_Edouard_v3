using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LightSwitchScript : MonoBehaviour
{
    public Light roomLight;  // La lumière principale de la pièce
    public AudioClip switchSound; // Le son à jouer lors de l'activation
    private AudioSource audioSource;
    private bool isLightOn = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();  // Assurez-vous que l'objet possède un AudioSource
        roomLight.enabled = isLightOn; // Initialement éteinte
    }

    public void ToggleLight()
    {
        isLightOn = !isLightOn;
        roomLight.enabled = isLightOn;

        // Jouer le son
        if (audioSource != null && switchSound != null)
        {
            audioSource.PlayOneShot(switchSound);
        }
    }
}
