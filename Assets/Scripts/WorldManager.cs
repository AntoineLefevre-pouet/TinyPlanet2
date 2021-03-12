using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldManager : MonoBehaviour
{
    public GameObject[] zones;
    public GameObject questionUI;

    public void ZoneAppear(int nbZone)
        {
            zones[nbZone].SetActive(true);
        }
}

