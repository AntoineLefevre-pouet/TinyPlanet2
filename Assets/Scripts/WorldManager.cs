using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldManager : MonoBehaviour
{
    public GameObject zone1;
    public GameObject zone2;
    public GameObject questionUI;

    public void Zone1()
        {
            Debug.Log(message: "Réponse 1");
            zone1.SetActive(true);
            questionUI.SetActive(false);
        }

    public void Zone2()
        {
            Debug.Log(message: "Réponse 2");
            zone2.SetActive(true);
            questionUI.SetActive(false);
        }
}

