using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagement : MonoBehaviour
{
    public void ChangeScene(Teleportation)
    {
        
        SceneManager.LoadScene("Teleportation");

    }

    public void ChangeScene(Mouvement)
    {
        
        SceneManager.LoadScene("Mouvement");

    }

}