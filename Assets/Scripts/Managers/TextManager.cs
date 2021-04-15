using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public string text;
    public GameObject inputField;
    public GameObject textDisplay;

    public void StoreText()
    {
        text = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = text;
    }
}
