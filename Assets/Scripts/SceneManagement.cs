using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagement : MonoBehaviour
{
    public void ChangeSceneToTeleportation()
    {
        
        SceneManager.LoadScene("Teleportation");

    }

    public void ChangeSceneToMouvement()
    {
        
        SceneManager.LoadScene("Mouvement");

    }

}