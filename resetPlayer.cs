using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resetPlayer : MonoBehaviour
{
        float xReset; //decalre xReset as a float
        float yReset; //decalre yReset as a float
        float zReset; //decalre zReset as a float
    // Start is called before the first frame update
    void Start()
    {
        xReset = -0.24f; //decalre xReset as a float value of -0.24 when the game starts
        yReset = 10.58f; //decalre yReset as a float value of 10.58 when the game starts
        zReset = 6.19f; //decalre zReset as a float value of 6.19 when the game starts
    }
    private void OnCollisionEnter(Collision other){ //Built in unity method utilizer collisions
        if(other.gameObject.tag == "Obby" || other.gameObject.layer == 6) //if the object hits anything with a tag of "Obby" or Object layer 6 also called "Obby"
        {
            transform.position = new Vector3(xReset,yReset,zReset); //return the object back to the starting point declared in start
            SceneManager.LoadScene("Try Again"); //load the try again scene when you crash
            
        }
    }
}
