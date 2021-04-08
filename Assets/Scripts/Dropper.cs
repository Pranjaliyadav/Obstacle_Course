using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour        //for dropping the dropper from a certain height
{
    [SerializeField]float TimeToWait = 5f;
    MeshRenderer renderer;    //meshrenderer is an object here ig more like a component from unity.we can change handle with components property tis way too
    Rigidbody rigidBody;       //same with rigidBody component
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();    //another way of using GetComponent<>();
        rigidBody = GetComponent<Rigidbody>();
        renderer.enabled = false;                  //setting here false as its gonna update once when game starts
        rigidBody.useGravity = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > TimeToWait)   //Time.time ==> Time is aclass here , time is a property of that class , its in seconds, tells how much time have elapsed since starting
        {
            renderer.enabled = true;                    //now changing it as the dropper is gonna fall,player needs to see it and turning on the gravity for falling
            rigidBody.useGravity = true;

        }
    }
}
