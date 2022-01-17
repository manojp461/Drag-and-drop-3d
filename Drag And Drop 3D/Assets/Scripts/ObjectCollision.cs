using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectCollision : MonoBehaviour
{
    public static bool isCollision;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Correct")
        {
            isCollision = true;
            ObjectCollisionFunctionality.instance.CollisionBody();
        }
        else if(collision.gameObject.tag == "Wrong")
        {
            isCollision = false;
            ObjectCollisionFunctionality.instance.CollisionBody();
        }
    }
}