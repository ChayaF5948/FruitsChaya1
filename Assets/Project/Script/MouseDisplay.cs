using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDisplay : MonoBehaviour
{
    private Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
        Cursor.visible = true;
    }

   
}
