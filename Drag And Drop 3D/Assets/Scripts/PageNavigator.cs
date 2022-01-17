using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PageNavigator : MonoBehaviour
{
    public GameObject Page01;
    public GameObject Page02;

    private ObjectCollision objectCollision;

    //private void Start()
    //{
    //    //objectCollision = gameObject.GetComponent<ObjectCollision>();
    //}
    public void Page01NextButton()
    {
        Page01.SetActive(false);
        Page02.SetActive(true);
    }

    public void Page02PreviousButton()
    {
        Page02.SetActive(false);
        Page01.SetActive(true);
        objectCollision.resultPanel.SetActive(false);
        objectCollision.WrongResultText.SetActive(false);
        objectCollision.CorrectResultText.SetActive(false);
        objectCollision.cube01.SetActive(true);
        objectCollision.cylinder04.SetActive(true);
        //objectCollision.cube01.transform.position = objectCollision.orginalCube01Pos;
    }
}
