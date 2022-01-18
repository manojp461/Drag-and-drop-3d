using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectCollision : MonoBehaviour
{
    public static bool isCollision;

    public void OnCollisionEnter(Collision collision)
    {
        // Cube01 dragged onto the Cylinder04
        if (collision.gameObject.tag == "Correct")
        {
            isCollision = true;
            ObjectCollisionFunctionality.instance.CollisionBody();
        }
        // Cube01 dragged onto the other Gameobjects
        else if (collision.gameObject.tag == "Wrong")
        {
            isCollision = false;
            ObjectCollisionFunctionality.instance.CollisionBody();
        }
    }
}