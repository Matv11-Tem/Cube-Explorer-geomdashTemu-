using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menumanager : MonoBehaviour
{
    public void StartGame()
    {
        //See on nupu play jaoks
        SceneManager.LoadScene(1);

    }

    public void QuitGame()
    {
        //see on nuppu quit jaoks
        Application.Quit();

    }

    public void GoToLevel2()
    {
        SceneManager.LoadScene(2);


    }











}
