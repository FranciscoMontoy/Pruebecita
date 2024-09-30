using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PantallaCompletatoguapa : MonoBehaviour
{
    public Toggle togglePantallaCiompleta;


    // Start is called before the first frame update
    void Start()
    {
        if(Screen.fullScreen)
        {
            togglePantallaCiompleta.isOn = true;
        }
        else
        {
            togglePantallaCiompleta.isOn = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivarPantallaCompleta(bool pantallaCompleta)
    {
        Screen.fullScreen = pantallaCompleta;
    }
}
