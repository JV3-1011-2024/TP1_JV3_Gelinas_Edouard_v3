using UnityEngine;

public class Serrure : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip sonCleDansSerrure;
    private bool cleInseree = false;

    void Start()
    {
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cle") && !cleInseree)
        {
            InsererCle();
        }
    }

    public void InsererCle()
    {
        audioSource.PlayOneShot(sonCleDansSerrure);
        cleInseree = true;
    }
}