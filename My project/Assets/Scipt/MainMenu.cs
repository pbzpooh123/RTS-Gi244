using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private string newScene;
    // Start is called before the first frame update
    public void NewGame()
    {
        SceneManager.LoadScene(newScene);
    }

    // Update is called once per frame
   public void ExitGame()
    {
        Application.Quit();
    }
}
