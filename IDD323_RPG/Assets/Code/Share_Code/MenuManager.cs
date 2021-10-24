using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void Sperm()
    {
        SceneManager.LoadScene("Sperm_Adventure");
    }
    public void Dungeon()
    {
        SceneManager.LoadScene("Dungeon_adventure");
    }
    public void LoadScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }
    public void exit()
    {
        Application.Quit();
    }
    public void mainmenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void nextlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
