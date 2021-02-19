using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnZone : MonoBehaviour
{

    void OnMouseDown()
    {
      Debug.Log("La sphère est détectée");
      GameManager.instance.ShowQuestionUI();
    }

}
