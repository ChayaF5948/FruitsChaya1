using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "GameManeger", menuName = "Game manager", order = 54)]

public class GameManager : ScriptableObject
{
    public UnityAction OngameOver;

    private bool isGameOver = false;
    public bool IsGameOver
    {
        get { return isGameOver; }
        set
        {
            isGameOver = value;
            if (isGameOver = true)
            {
                OngameOver?.Invoke();
            }
        }
    }
}
