using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour    //for changing the color after collisoion and the tag associated with obstacle
{
    private void OnCollisionEnter(Collision other) //OnCollisionEnter is used for collision purposes , here other denote what are we colliding with
    {
        //Debug.Log("Bumped into walls");
        if(other.gameObject.tag == "Player"){    //other.gameObject.tag ==> gameObject is a property for other, u can give tags in unity 
            GetComponent<MeshRenderer>().material.color = Color.white;   //GetCompenent<Component Name>() gets the component we want to deal with
            //here we're dealing with material(outer color) to change the color of material to white after we collide with them
            gameObject.tag = "Hit";  //changing the tag so that we dont get points for same object more than once
        }
    }
}
