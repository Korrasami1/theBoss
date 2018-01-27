using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

    public void NewGameBton(string newGameLevel)
    {
        SceneManager.LoadScene(newGameLevel);
    }

    public void CreditsBtn(string credits)
    {
        SceneManager.LoadScene(credits);
    }

    public void BackBtn(string sceneSelect)
    {
        SceneManager.LoadScene(sceneSelect);
    }

    public void ExitGameBtn()
    {
        Application.Quit();
    }

}
