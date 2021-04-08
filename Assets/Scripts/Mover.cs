using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour  //for Player_dodgy
{
    /*      using [SerializeFiled] will let us test these variables in unity without changing values here again n again
            we can edit them there and that'll not cause any changes here
    [SerializeField] float zValue = 0;
    */
    [SerializeField] float moveSpeed = 5f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions(){
        Debug.Log("Welcome to the game");
        Debug.Log("move your player with WASD");
        Debug.Log("dont hit the walls");
        
    }

    void MovePlayer(){
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;           //to use WSAD as input
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;  //Time.deltaTime is used here for FPS purposes ,it can change its value 
                                                                                //as its dependent on graphic specs, providing the same gameplay for evryone
        transform.Translate(xValue,0,zValue);            //Translate is a inbuilt unity function that can make player move,it takes (x,y,z)

    }
}


