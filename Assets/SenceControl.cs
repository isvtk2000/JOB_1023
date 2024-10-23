using UnityEngine;
using UnityEngine.SceneManagement;

public class SenceControl : MonoBehaviour
{
    public void LoadSence(string senceName)
    {
        SceneManager.LoadScene(senceName);
    }

    public void QuitGame()
    {
       Application.Quit();
    }
}

