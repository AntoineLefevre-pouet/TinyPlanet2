using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnZone : MonoBehaviour
{
  public GameObject questionUI;

    void OnMouseDown()
    {
      Debug.Log("La sphère est détectée");

      questionUI.SetActive(true);
    }
}
