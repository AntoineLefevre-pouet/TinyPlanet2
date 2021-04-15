using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxManager : MonoBehaviour
{

    public Material bleu;
    public Material rose;
    public Material vert;
    public Material gris;

    // Start is called before the first frame update

    public void ChangeSkyBlue()
    {
        RenderSettings.skybox = bleu;
    }

    public void ChangeSkyPink()
    {
        RenderSettings.skybox = rose;
    }

    public void ChangeSkyGreen()
    {
        RenderSettings.skybox = vert;
    }

    public void ChangeSkyGrey()
    {
        RenderSettings.skybox = gris;
    }
}
