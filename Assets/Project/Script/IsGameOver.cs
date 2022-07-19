using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IsGameOver : MonoBehaviour
{

    [SerializeField] private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager.OngameOver += GameOver; 
    }

    private void GameOver()
    {
        StartCoroutine(WaitWhenGameOver());
    }

    private IEnumerator WaitWhenGameOver()
    {
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene(2);

    }
}
