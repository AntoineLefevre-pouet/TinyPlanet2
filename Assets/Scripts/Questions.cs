using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Questions : MonoBehaviour
{
  public GameObject[] questions;
  public int numeroZone;

  public void QuestionAppear(int nbQuestion)
  {
    questions[nbQuestion].SetActive(true);
  }

  public void OnMouseDown()
  {
    GameManager.instance.ShowQuestionUI();
    QuestionAppear(numeroZone);
    Debug.Log("La zone" + numeroZone + "est activée");
  }

}
