using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.UI;

public class FRuitShooter : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private GameObject[] prefab;
    [SerializeField]
    private float minForce;
    [SerializeField]
    private float maxForce;
    [SerializeField]
    private float minTime = 1;
    [SerializeField]
    private float maxTime = 3;
    [SerializeField]
    private float minAngel = -60;
    [SerializeField]
    private float maxAngel = 60;

    private void Start()
    {
        StartCoroutine(ThrowLoop());
        StartCoroutine(SpeedingSpeed());
        gameManager.OngameOver += GameOver;
    }

    private IEnumerator ThrowLoop()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minTime, maxTime));
            ThrowFruit();
        }
    }
    private IEnumerator SpeedingSpeed()
    {
        while (true)
        {
            yield return new WaitForSeconds(10f);
            float max = maxTime * 0.9f;
            maxTime = max;
        }
    }

    public void ThrowFruit()
    {
        transform.parent.localEulerAngles = new Vector3(0, 0, Random.Range(minAngel, maxAngel));
        GameObject go = Instantiate(prefab[Random.Range(0, prefab.Length)],
        transform.position, Quaternion.identity);
        //GameObject go = Instantiate(prefab, transform.position, Quaternion.identity);
        go.GetComponent<Rigidbody>().AddForce(transform.forward * Random.Range(minForce, maxForce));
    }
    private void GameOver()
    {
        this.gameObject.SetActive(false);
    }
}
