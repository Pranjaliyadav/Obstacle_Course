using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour      //for the rotation of spinner
{
    [SerializeField] float xAngle = 0f;   //taking the same component name as mentioned in unity as thats the PRIME rule of using SerializeField
    [SerializeField] float yAngle = 0f;
    [SerializeField] float zAngle = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xAngle , yAngle , zAngle);     //we can rotate using this
    }
}
