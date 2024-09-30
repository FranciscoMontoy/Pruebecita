using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Brillotoguapo : MonoBehaviour
{
    public Slider slider;
    public Image imagenNegra;
    public float brilloSlideValue;

    // Start is called before the first frame update
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("brilloPantalla", 0.5f);
        imagenNegra.color = new Color(imagenNegra.color.r, imagenNegra.color.g, imagenNegra.color.b, slider.value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeSlider(float valor)
    {
        brilloSlideValue = valor;
        PlayerPrefs.SetFloat("brilloPantalla", brilloSlideValue);
        imagenNegra.color = new Color(imagenNegra.color.r, imagenNegra.color.g, imagenNegra.color.b, slider.value);
    }
}
