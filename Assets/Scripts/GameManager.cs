using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public GameObject questionUI;
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

    public void Pause()
    {
        Debug.Log(message: "Pause");
        Time.timeScale = 0;
    }

    public void UnPause()
    {
        Debug.Log(message: "UnPause");
        Time.timeScale = 1;
    }

    public void ShowQuestionUI()
    {
        if (questionUI.activeSelf == false)
        {
            Pause();
            questionUI.SetActive(true);
        }
    }
}