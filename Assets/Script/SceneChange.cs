using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // -------------------- MAIN MENU
    public void PlaytoMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void PlayCutscene1()
    {
        SceneManager.LoadScene(1);
    }

    public void PlayCharacterSelect()
    {
        SceneManager.LoadScene(2);
    }

    // -------------------- GAME
    public void PlayGame()
    {
        SceneManager.LoadScene(3);
    }

    public void ResultScreen()
    {
        SceneManager.LoadScene(4);
    }

    public void PlayGame5()
    {
        SceneManager.LoadScene(5);
    }

    public void ResultScreen5()
    {
        SceneManager.LoadScene(6);
    }

    public void PlayGame10()
    {
        SceneManager.LoadScene(7);
    }

    public void ResultScreen10()
    {
        SceneManager.LoadScene(8);
    }

    public void PlayGame15()
    {
        SceneManager.LoadScene(9);
    }

    public void ResultScreen15()
    {
        SceneManager.LoadScene(10);
    }

    public void PlayGame20()
    {
        SceneManager.LoadScene(11);
    }

    public void ResultScreen20()
    {
        SceneManager.LoadScene(12);
    }

    // -------------------- FIN & EXTRAS

    public void PlayInstructions()
    {
        SceneManager.LoadScene(15);
    }

    public void PlayFinalCutscene()
    {
        SceneManager.LoadScene(13);
    }

    public void PlayEndScene()
    {
        SceneManager.LoadScene(14);
    }

    public void QuitGame ()
    {
    Application.Quit();
    Debug.Log("El juego se cerro");
    }

}
