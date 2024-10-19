using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SwitchLight : MonoBehaviour
{
    private AudioSource audioSource;
    public Light roomLight; // Référence à la lumière
    public AudioClip switchSound; // Son de l'interrupteur

    private XRGrabInteractable grabInteractable;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
        // Vérifiez si la lumière est assignée, sinon, éteignez-la
        if (roomLight != null)
        {
            roomLight.enabled = false; // La lumière est éteinte au départ
        }

        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.onActivate.AddListener(ActivateSwitch); // Écoutez l'activation
    }

    void ActivateSwitch(XRBaseInteractor interactor)
    {
        ToggleLight(); // Alterne l'état de la lumière
        PlaySwitchSound(); // Joue le son de l'interrupteur
    }

    void ToggleLight()
    {
        if (roomLight != null)
        {
            roomLight.enabled = !roomLight.enabled; // Alterne l'état de la lumière
        }
    }

    void PlaySwitchSound()
    {
        if (audioSource != null && switchSound != null)
        {
            audioSource.PlayOneShot(switchSound); // Joue le son de l'interrupteur
        }
    }
}
