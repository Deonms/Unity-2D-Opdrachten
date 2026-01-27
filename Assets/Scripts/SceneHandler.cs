using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    public void RestartGame()
    {
        print("game restart");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}


