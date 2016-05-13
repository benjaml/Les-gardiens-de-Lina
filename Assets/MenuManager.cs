using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuManager : MonoBehaviour {


    public void SetCredit()
    {
        SceneManager.LoadScene("Crédit");
    }

    public void SetMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void SetGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void SetTuto()
    {
        SceneManager.LoadScene("Tuto");
    }

    public void Quit()
    {
        Application.Quit();
    }


}
