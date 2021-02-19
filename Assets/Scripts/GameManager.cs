using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
  public GameObject questionUI;
  public Image panel;

  public static GameManager instance;

  private void Awake()
  {
    if(instance != null)
    {
      Debug.LogWarning("Il y a plus d'une instance de GameManager dans la scène");
      return;
    }

    instance = this; // permet d'accéder au script depuis n'importe où
  }

  public void ShowQuestionUI()
  {
    if(questionUI.activeSelf == false) {
      questionUI.SetActive(true);
      panel.enabled = true;
    }
  }

  public void HideQuestionUI()
  {
    if(questionUI.activeSelf == true) {
      questionUI.SetActive(false);
      panel.enabled = false;
    }
  }

}
