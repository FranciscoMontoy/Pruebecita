using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sonidotoguapo : MonoBehaviour
{

    //Declarando variables
    public Slider slider;
    public float sliderValue;
    public Image imagenMute;



    // Start is called before the first frame update
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("volumenAudio", 0.5f); //Con Get se invoca la variable Audio y después de la coma se añade el valor o variable.
        AudioListener.volume = slider.value;
        RevisarMute();

    }
    public void ChangeSlider(float valor)
    {
        sliderValue = valor;
        PlayerPrefs.SetFloat("volumenAudio", sliderValue);
        AudioListener.volume = sliderValue;
        RevisarMute();
    }

    public void RevisarMute() //Revisar el valor del slider y en función de si llega a 0 o no, se activa la imagen deseada.
    {
        if (sliderValue == 0f)
        {
            imagenMute.enabled = true;
        }
        else
        {
            imagenMute.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
