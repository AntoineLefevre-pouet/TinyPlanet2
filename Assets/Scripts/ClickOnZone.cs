using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnZone : MonoBehaviour
{
  public int numero;

    void OnMouseDown()
    {
      Debug.Log(numero);
      GameManager.instance.ShowQuestionUI();
    }

}
