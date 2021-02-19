using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToHide : MonoBehaviour
{
  void OnMouseDown()
  {
    Debug.Log("La zone est détectée");
    GameManager.instance.HideQuestionUI();
  }
}
