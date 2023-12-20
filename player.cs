using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float xVal; //decalre xVal as a float
    float yVal; //decalre yVal as a float
    float zVal; //decalre zVal as a float
    float playerSpeed; //decalre playerSpeed as a float
    Rigidbody playerRB; //declare you are using a ridgidBody

    // Start is called before the first frame update
    void Start()
    {
        playerSpeed = 30f; //set player movement speed to 30
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer(); //call to the movePlayer custom Method
    }
    void movePlayer(){ //declared the method
        xVal = Input.GetAxis("Horizontal") * Time.deltaTime * playerSpeed; //xVal set to the Input Manager values for when the player preces a or d to move horizontally
        zVal = 25f * Time.deltaTime; // makes the player constantly move foward at 25 units times Time.deltaTime
        transform.Translate(xVal, yVal, zVal); //move the player by the declared units from the code above
    }
    
}
