using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollisionFunctionality : MonoBehaviour
{
    public GameObject cube01;
    public GameObject sphere02;
    public GameObject cube03;
    public GameObject cylinder04;
    public GameObject resultPanel;
    public GameObject WrongResultText;
    public GameObject CorrectResultText;

    private Vector3 orginalCube01Pos;

    public static ObjectCollisionFunctionality instance;

    private void Start()
    {
        instance = this;
        orginalCube01Pos = cube01.transform.position;
    }
    public void CollisionBody()
    {
        if (ObjectCollision.isCollision == true)
        {
            cube01.SetActive(false);
            cylinder04.SetActive(false);
            resultPanel.SetActive(true);
            CorrectResultText.SetActive(true);
        }
        else if (ObjectCollision.isCollision == false)
        {
            resultPanel.SetActive(true);
            WrongResultText.SetActive(true);
            cube01.transform.position = orginalCube01Pos;
        }
    }
}