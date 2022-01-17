using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PageNavigator : MonoBehaviour
{
    public GameObject Page01;
    public GameObject Page02;
    //public TMP_Text resultText;
    //public Cube01AndCylinder04Collision cube01AndCylinder04Collision;
    //public GameObject resultPanel;
    //public TMP_Text resultText1;

    //public void ResultTextUpdate()
    //{
    //    if(cube01AndCylinder04Collision.isCollision == true)
    //    {
    //        resultPanel.SetActive(true);
    //        resultText1.GetComponent<TextMeshPro>().text = "Wrong Answer";
    //    }
    //}

    private void Update()
    {
        //if (cube01AndCylinder04Collision.isCollision == true)
        //{
        //    resultPanel.SetActive(true);
        //    resultText1.GetComponent<TextMeshPro>().text = "Wrong Answer";
        //}
    }
    public void Page01NextButton()
    {
        Page01.SetActive(false);
        Page02.SetActive(true);
    }
}
