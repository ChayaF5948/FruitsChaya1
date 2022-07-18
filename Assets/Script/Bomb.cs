using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Bomb : MonoBehaviour
{
    //[SerializeField] GameObject explosion;
    [SerializeField] private ParticleSystem ps;
  public GameManager gameManager;

    private void Start()
    {
        
    }



    public void GameOver()
    {
        Vector3 position1 = gameObject.transform.position;
        GameObject go = Instantiate(ps.gameObject,position1,Quaternion.identity);
        //Destroy(go, 2.0f);
        //StartCoroutine(Explosion());
        gameManager.IsGameOver = true;
        Destroy(gameObject);
        //SceneManager.LoadScene(2);
        //Vector3 position1 = gameObject.transform.position;
        //Destroy(gameObject);
        //Instantiate(explosion);
        //transform.position = position1;
        //StartCoroutine(Explosion());


    }

    //private IEnumerator Explosion()
    //{
    //    yield return new WaitForSeconds(3f);
    //    SceneManager.LoadScene(2);
    //}



}
