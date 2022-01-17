using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube01AndCylinder04Collision : MonoBehaviour
{
    public GameObject cube01;
    public GameObject sphere02;
    public GameObject cube03;
    public GameObject cylinder04;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Cylinder04")
        {
            cube01.SetActive(false);
            cylinder04.SetActive(false);
        }
    }
}
