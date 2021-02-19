using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomDezoom : MonoBehaviour
{
    public KeyCode zoom;
    public KeyCode dezoom;

    public float zoomSpeed;

    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0 && Camera.main.orthographicSize > 5)
        {
             Camera.main.orthographicSize -= zoomSpeed;
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0 && Camera.main.orthographicSize < 50)
        {
             Camera.main.orthographicSize += zoomSpeed;
        }
    }
}
