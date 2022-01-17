using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PageNavigator : MonoBehaviour
{
    public GameObject Page01;
    public GameObject Page02;

    public void Page01NextButton()
    {
        Page01.SetActive(false);
        Page02.SetActive(true);
    }

    public void Page02PreviousButton()
    {
        Page02.SetActive(false);
        Page01.SetActive(true);
        ObjectCollisionFunctionality.instance.CorrectResultText.SetActive(false);
        ObjectCollisionFunctionality.instance.WrongResultText.SetActive(false);
        ObjectCollisionFunctionality.instance.resultPanel.SetActive(false);
        ObjectCollisionFunctionality.instance.cube01.SetActive(true);
        ObjectCollisionFunctionality.instance.cylinder04.SetActive(true);
        Debug.Log('1');
    }
}
