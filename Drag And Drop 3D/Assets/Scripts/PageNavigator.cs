using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PageNavigator : MonoBehaviour
{
    [Header("Page01 GameObjects")]
    public GameObject Page01;
    public GameObject Page012D;

    [Header("Page02 GameObject")]
    public GameObject Page02;

    [Header("Page03 GameObjects")]
    public GameObject Page03;
    public GameObject Page032D;
    public GameObject ammeterNeedle;
    public Slider slider;

    [Header("Page04 GameObjects")]
    public GameObject Page04;
    public GameObject Page042D;
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
        Page012D.SetActive(false);
        Page02.SetActive(true);
    }

    public void Page02PreviousButton()
    {
        Page02.SetActive(false);
        Page01.SetActive(true);
        Page012D.SetActive(true);
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
        Page032D.SetActive(true);
    }
    public void Page03NextButton()
    {
        Page03.SetActive(false);
        Page032D.SetActive(false);
        Page04.SetActive(true);
        Page042D.SetActive(true);
        slider.gameObject.SetActive(false);
        // Reset Slider value to zero
        slider.value = 0;
    }
    public void Page03PreviousButton()
    {
        Page03.SetActive(false);
        Page032D.SetActive(false);
        Page02.SetActive(true);
    }

    public void Page04PreviousButton()
    {
        Page04.SetActive(false);
        Page042D.SetActive(false);
        Page03.SetActive(true);
        Page032D.SetActive(true);
        slider.gameObject.SetActive(true);
        // Reset Slider value to zero
        slider.value = 0;
    }
    public void AmmeterDeflection()
    {
        // Ammeter needle value
        switch (slider.value)
        {
            case 0:
                ammeterNeedle.transform.localRotation = Quaternion.Euler(new Vector3(0, -90, -90));
                break;
            case 1: ammeterNeedle.transform.localRotation = Quaternion.Euler(new Vector3(0, -80, -90));      
                break;
            case 2:
                ammeterNeedle.transform.localRotation = Quaternion.Euler(new Vector3(0, -60, -90));
                break;
            case 3:
                ammeterNeedle.transform.localRotation = Quaternion.Euler(new Vector3(0, -40, -90));
                break;
            case 4:
                ammeterNeedle.transform.localRotation = Quaternion.Euler(new Vector3(0, -20, -90));
                break;
            case 5:
                ammeterNeedle.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, -90));
                break;
            case 6:
                ammeterNeedle.transform.localRotation = Quaternion.Euler(new Vector3(0, 20, -90));
                break;
            case 7:
                ammeterNeedle.transform.localRotation = Quaternion.Euler(new Vector3(0, 40, -90));
                break;
            case 8:
                ammeterNeedle.transform.localRotation = Quaternion.Euler(new Vector3(0, 60, -90));
                break;
            case 9:
                ammeterNeedle.transform.localRotation = Quaternion.Euler(new Vector3(0, 60, -90));
                break;
            case 10:
                ammeterNeedle.transform.localRotation = Quaternion.Euler(new Vector3(0, 80, -90));
                break;
            case 11:
                ammeterNeedle.transform.localRotation = Quaternion.Euler(new Vector3(0, 90, -90));
                break;
        }
    }
    private void Update()
    {
        AmmeterDeflection();
    }

    public void PlayAnimation()
    {
        //Animation play method
        tube01Animation.enabled = true;
        tube01.GetComponent<MeshRenderer>().material = tube01materialDefault;
        box01.SetActive(true);
        sphere01.SetActive(true);
    }
    public void PauseAnimation()
    {
        //Animation pause method
        tube01Animation.enabled = false;
        tube01.GetComponent<MeshRenderer>().material = tube01materialBlue;
        box01.SetActive(false);
        sphere01.SetActive(false);
    }
}