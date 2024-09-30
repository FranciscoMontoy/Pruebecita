using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Calidadtoguapa : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public int calidad;

    // Start is called before the first frame update
    void Start()
    {
        calidad = PlayerPrefs.GetInt("numeroCalidad", 3);
        dropdown.value = calidad;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Elegirfuncion()
    {
        QualitySettings.SetQualityLevel(dropdown.value, true);
        PlayerPrefs.SetInt("numerocalidad", dropdown.value);
        calidad = dropdown.value;
    }
}
