using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour     //for counting how much time dodgy hits the obstacle
{
    int hits = 0;
    private void OnCollisionEnter(Collision other) {
        
        if(other.gameObject.tag != "Hit")
        {
            hits++;
            Debug.Log("You've bumped into a thing this many times : " + hits);     //tells how many times we've hit,, "Hit" is referenced to ObjectHit script.
            //if its hit that means it has already been collided with.so no need to increment hit score
        }
       
        
    }
    
}
