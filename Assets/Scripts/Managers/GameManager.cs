using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public GameObject questionUI;
    public static GameManager instance;
    public GameObject[] questions;
    public GameObject questionsSet;

    private void Awake()
    {
        instance = this; // permet d'accéder au script depuis n'importe où
    }

    public void ShowQuestionUI(int nbQuestion)
    {
        if (questionUI.activeSelf == false)
        {
            Pause();
            questionUI.SetActive(true);
            questions[nbQuestion].SetActive(true);
        }
    }

    public void HideQuestionUI()
    {
        if (questionUI.activeSelf == true)
        {
            UnPause();
            GameObject.FindGameObjectWithTag("Sets").SetActive(false);
            questionUI.SetActive(false);
        }
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
}