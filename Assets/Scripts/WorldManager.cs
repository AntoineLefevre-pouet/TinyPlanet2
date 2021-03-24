using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldManager : MonoBehaviour
{
    public GameObject[] actions;
    public GameObject questionUI;

    public void ZoneAppear(int nbAction)
        {
            actions[nbAction].SetActive(true);
            questionUI.SetActive(false);
        }
}