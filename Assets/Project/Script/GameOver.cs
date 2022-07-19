using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        audioSource.Play();
       
    }
}
