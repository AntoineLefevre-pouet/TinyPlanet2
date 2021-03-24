using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnZone : MonoBehaviour
{
    public int numero;

    void OnMouseDown()
    {
      Debug.Log("La zone " + numero + " est activée");
      GameManager.instance.ShowQuestionUI(numero);
    }
}