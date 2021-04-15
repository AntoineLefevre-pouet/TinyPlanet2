using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldManager : MonoBehaviour
{
    public GameObject[] objets;
    public GameObject questionUI;

    public void SetActive(int nbObjet)
        {
            objets[nbObjet].SetActive(true);
        }

    public void SetInActive(int nbObjet)
        {
            objets[nbObjet].SetActive(false);
        }
}