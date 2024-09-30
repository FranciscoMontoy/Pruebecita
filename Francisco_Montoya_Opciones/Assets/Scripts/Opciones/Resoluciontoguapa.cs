using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Resoluciontoguapa : MonoBehaviour
{
    public TMP_Dropdown resolucionDropdown;
    public Toggle toggle;
    Resolution[] resolutions;

    // Start is called before the first frame update
    void Start()
    {
        if (Screen.fullScreen)
        {
            toggle.isOn = true;
        }
        else
        {
            toggle.isOn= false;
        }
        RevisarResolucion();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivarPantallaCompleta(bool pantallaCompleta)
    {
        Screen.fullScreen = pantallaCompleta;
    }

    public void RevisarResolucion()
    {
        resolutions = Screen.resolutions;
        resolucionDropdown.ClearOptions();
        List<string>options = new List<string>();
        int resolucionActual = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " X" + resolutions[i].height;
            options.Add(option);
            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                resolucionActual = i;
            }
        }
        resolucionDropdown.AddOptions(options);
        resolucionDropdown.value = resolucionActual;
        resolucionDropdown.RefreshShownValue();
        resolucionDropdown.value = PlayerPrefs.GetInt("numeroresSolucion", 0);
    }

    public void CambiarResolucion(int indicadorResolucion)
    {
        PlayerPrefs.SetInt("numeroresSolucion", resolucionDropdown.value);
        Resolution resolucion = resolutions[indicadorResolucion];
        Screen.SetResolution(resolucion.width, resolucion.height, Screen.fullScreen);
    }
}
