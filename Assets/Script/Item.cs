using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    [SerializeField] private GameObject emitter;
    //private int score;
    //[SerializeField]
    // private Text scoreText;
    public int pointV;

    public void Explode()
    {
        Instantiate(emitter, transform.position, transform.rotation);
        Die();
        ScoreManager.Instance.AddScore();
        
        //GetComponent<ScoreManager>.AddScore()
        //score ++;
        //scoreText.text = "Score: " + score;

    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
