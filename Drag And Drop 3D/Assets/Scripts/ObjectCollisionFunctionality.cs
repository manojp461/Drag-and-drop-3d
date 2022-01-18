using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollisionFunctionality : MonoBehaviour
{
    [Header("Collision GameObjects")]
    public GameObject cube01;
    public GameObject sphere02;
    public GameObject cube03;
    public GameObject cylinder04;
    public GameObject resultPanel;
    public GameObject WrongResultText;
    public GameObject CorrectResultText;

    [Header("Cube01 GameObject Transform")]
    public Vector3 orginalCube01Pos;

    public static ObjectCollisionFunctionality instance;

    private void Start()
    {
        instance = this;
        // Cube01 orginal position
        orginalCube01Pos = cube01.transform.position;
    }
    public void CollisionBody()
    {
        // Cube01 dragged onto the Cylinder04
        if (ObjectCollision.isCollision == true)
        {
            cube01.SetActive(false);
            cylinder04.SetActive(false);
            resultPanel.SetActive(true);
            CorrectResultText.SetActive(true);
        }
        // Cube01 dragged onto the other Gameobjects
        else if (ObjectCollision.isCollision == false)
        {
            resultPanel.SetActive(true);
            WrongResultText.SetActive(true);
            cube01.transform.position = orginalCube01Pos;
        }
    }
}