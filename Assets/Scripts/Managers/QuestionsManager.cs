using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionsManager : MonoBehaviour
{
  public GameObject[] questions;

  public void QuestionsSet(int nbQuestion)
    {
        questions[nbQuestion].SetActive(true);
    }
}