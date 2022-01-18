using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PageNavigator : MonoBehaviour
{
    public GameObject Page01;
    public GameObject Page01NavigationButtons;
    public GameObject Page02;
    public GameObject Page03;
    public GameObject Page03NavigationButtons;
    public GameObject ammeterNidle;
    public Slider slider;

    public void Page01NextButton()
    {
        Page01.SetActive(false);
        Page01NavigationButtons.SetActive(false);
        Page02.SetActive(true);
    }

    public void Page02PreviousButton()
    {
        Page02.SetActive(false);
        Page01.SetActive(true);
        Page01NavigationButtons.SetActive(true);
        ObjectCollisionFunctionality.instance.cube01.transform.position = ObjectCollisionFunctionality.instance.orginalCube01Pos;
        ObjectCollisionFunctionality.instance.CorrectResultText.SetActive(false);
        ObjectCollisionFunctionality.instance.WrongResultText.SetActive(false);
        ObjectCollisionFunctionality.instance.resultPanel.SetActive(false);
        ObjectCollisionFunctionality.instance.cube01.SetActive(true);
        ObjectCollisionFunctionality.instance.cylinder04.SetActive(true);
    }

    public void Page02NextButton()
    {
        Page02.SetActive(false);
        Page03.SetActive(true);
        Page03NavigationButtons.SetActive(true);
    }
    public void Page03PreviousButton()
    {
        Page03.SetActive(false);
        Page03NavigationButtons.SetActive(false);
        Page02.SetActive(true);
    }
    float yRotation = 90.0f;
    public void AmmeterDeflection()
    {

        if(slider.value == 1 )
        {
            //ammeterNidle.transform.rotation = new Vector3(-0.75f, 0.0f, 0.0f);
            //Vector3 newRotation = new Vector3(0, -80, -90);
            //ammeterNidle.transform.eulerAngles = newRotation;
            ammeterNidle.transform.rotation = Quaternion.Euler(new Vector3(0, -80, -90));
        }
    }
    private void Update()
    {
        AmmeterDeflection();
    }
}