using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectCollision : MonoBehaviour
{
    public static bool isCollision;
    public ObjectCollisionFunctionality objectCollisionFunctionality;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Correct")
        {
            isCollision = true;
            objectCollisionFunctionality.CollisionBody();
        }
        else if(collision.gameObject.tag == "Wrong")
        {
            isCollision = false;
            objectCollisionFunctionality.CollisionBody();
        }
    }
}