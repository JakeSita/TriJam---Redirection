
using UnityEngine;
using UnityEngine.SceneManagement;
namespace DefaultNamespace{
public class  StartGm : MonoBehaviour
{
    

    public void StartGame()
    {
        SceneManager.LoadScene("GameLoop");
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
    

    public void MainMenu()
    {
        SceneManager.LoadScene("Start");
        StaticGameManager.Actualscore = 0;
    }
}
}
