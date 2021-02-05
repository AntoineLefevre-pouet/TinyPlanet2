using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomDezoom : MonoBehaviour
{
    public KeyCode zoom;
    public KeyCode dezoom;

    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0 && Camera.main.fieldOfView > 65)
        {
             Camera.main.fieldOfView -= 1;
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0 && Camera.main.fieldOfView < 135)
        {
             Camera.main.fieldOfView += 1;
        }
    }
}
