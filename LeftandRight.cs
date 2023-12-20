using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftandRight : MonoBehaviour
{
    float msOne; //declare movement speed for moving to the right
    float msTwo; //declare movement speed for moving to the left
    bool atLeftBound; //is it at the left most boundery
     // Start is called before the first frame update
    void Start()
    {
        msOne =7f;//movement speed to go right
        msTwo = -7f; //movement speed to go left
        atLeftBound = true; //at left bound declared true
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(msOne * Time.deltaTime, 0, 0); //move the object by the speed times Time.deltaTime
        if(transform.position.x >= 8.13){ //if it reaches the x coords of 8.13
            msOne = 0f; //set the first speed to 0
            atLeftBound = false; //not at left bound
            msTwo = -7f; // move to the left
        }
        if(transform.position.x <= -10){ //if the object coords are less than or equal to -10
            msTwo = 0f; //set speed 2 to 0
            atLeftBound = true; //its at the left bound
            msOne =6f;// move right
        }
        if (atLeftBound ==true){ //if its at the left bound
        transform.Translate(msOne * Time.deltaTime, 0, 0);   //move to the right
        }
        if (atLeftBound == false){ //if its not at the left bound
            transform.Translate(msTwo * Time.deltaTime, 0, 0); // move to the left
        }
    }
}