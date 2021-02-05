using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomDezoom : MonoBehaviour
{
    public KeyCode zoom;
    public KeyCode dezoom;

    void Update()
    {
        if(Input.GetKey(zoom) && Camera.main.fieldOfView > 65)
         {
             Camera.main.fieldOfView -= 1;
         }

         if (Input.GetKey(dezoom) && Camera.main.fieldOfView < 135)
         {
             Camera.main.fieldOfView += 1;
         }
    }
}
