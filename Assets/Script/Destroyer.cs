using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Fruits"))
        {
            Destroy(other.gameObject);
            ScoreManager.Instance.Disqualifications();
        }
        else if (other.gameObject.CompareTag("Bomb"))
        {
            Destroy(other.gameObject);
        }

    }
}
