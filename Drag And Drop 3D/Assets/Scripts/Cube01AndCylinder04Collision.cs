using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cube01AndCylinder04Collision : MonoBehaviour
{
    public GameObject cube01;
    public GameObject sphere02;
    public GameObject cube03;
    public GameObject cylinder04;
    public GameObject resultPanel;
    public GameObject WrongResultText;
    public GameObject CorrectResultText;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Correct")
        {
            cube01.SetActive(false);
            cylinder04.SetActive(false);
            resultPanel.SetActive(true);
            CorrectResultText.SetActive(true);
        }
        else if(collision.gameObject.tag == "Wrong")
        {
            resultPanel.SetActive(true);
            WrongResultText.SetActive(true);
        }
    }
}
