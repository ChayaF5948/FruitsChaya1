using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class Shoot : MonoBehaviour
{

    private AudioSource audioSource;
    private Camera camera;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        camera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    private void Fire()
    {
        print("Fire");
        audioSource.Play();

        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit raycastHit = new RaycastHit();

        if (Physics.Raycast(ray, out raycastHit, 1000))
        {
            Item item = raycastHit.rigidbody.gameObject.GetComponent<Item>();
           Bomb bomb = raycastHit.rigidbody.gameObject.GetComponent<Bomb>();

            if (item)
            {
                item.Explode();
            }
            else if (bomb)
            {
                bomb.GameOver();
            }
        }
    }
}
