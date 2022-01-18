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
    public GameObject Page04;
    public GameObject Page04NavigationButtons;
    public GameObject ammeterNidle;
    public Slider slider;

    public GameObject tube01;
    public GameObject box01;
    public GameObject sphere01;
    public Material tube01materialBlue;
    public Material tube01materialDefault;
    public Animator tube01Animation;

    private void Start()
    {
        tube01Animation.enabled = false;
    }

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
    public void Page03NextButton()
    {
        Page03.SetActive(false);
        Page04.SetActive(true);
        Page04NavigationButtons.SetActive(true);
        slider.gameObject.SetActive(false);
    }
    public void Page03PreviousButton()
    {
        Page03.SetActive(false);
        Page03NavigationButtons.SetActive(false);
        Page02.SetActive(true);
    }

    public void Page04PreviousButton()
    {
        Page04.SetActive(false);
        Page04NavigationButtons.SetActive(false);
        Page03.SetActive(true);
        slider.gameObject.SetActive(true);
    }
    public void AmmeterDeflection()
    {
        switch (slider.value)
        {
            case 0:
                ammeterNidle.transform.localRotation = Quaternion.Euler(new Vector3(0, -90, -90));
                break;
            case 1: ammeterNidle.transform.localRotation = Quaternion.Euler(new Vector3(0, -80, -90));      
                break;
            case 2:
                ammeterNidle.transform.localRotation = Quaternion.Euler(new Vector3(0, -60, -90));
                break;
            case 3:
                ammeterNidle.transform.localRotation = Quaternion.Euler(new Vector3(0, -40, -90));
                break;
            case 4:
                ammeterNidle.transform.localRotation = Quaternion.Euler(new Vector3(0, -20, -90));
                break;
            case 5:
                ammeterNidle.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, -90));
                break;
            case 6:
                ammeterNidle.transform.localRotation = Quaternion.Euler(new Vector3(0, 20, -90));
                break;
            case 7:
                ammeterNidle.transform.localRotation = Quaternion.Euler(new Vector3(0, 40, -90));
                break;
            case 8:
                ammeterNidle.transform.localRotation = Quaternion.Euler(new Vector3(0, 60, -90));
                break;
            case 9:
                ammeterNidle.transform.localRotation = Quaternion.Euler(new Vector3(0, 60, -90));
                break;
            case 10:
                ammeterNidle.transform.localRotation = Quaternion.Euler(new Vector3(0, 80, -90));
                break;
            case 11:
                ammeterNidle.transform.localRotation = Quaternion.Euler(new Vector3(0, 90, -90));
                break;
        }
    }
    private void Update()
    {
        AmmeterDeflection();
    }

    public void PlayAnimation()
    {
        tube01Animation.enabled = true;
        tube01.GetComponent<MeshRenderer>().material = tube01materialDefault;
        box01.SetActive(true);
        sphere01.SetActive(true);
    }
    public void PauseAnimation()
    {
        tube01Animation.enabled = false;
        tube01.GetComponent<MeshRenderer>().material = tube01materialBlue;
        box01.SetActive(false);
        sphere01.SetActive(false);
    }
}