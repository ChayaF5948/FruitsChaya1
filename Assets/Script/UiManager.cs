using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public static UiManager Instance;
    void Awake()
    {
        Instance = this;
    }
    public void StartGame ()
    {
        SceneManager.LoadScene(1);
    }
    public void ExsitGame ()
    {
        Application.Quit();
    }
    public void Bomb()
    {

    }
}
