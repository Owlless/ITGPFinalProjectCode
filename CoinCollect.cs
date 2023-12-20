using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    int counter; //create coin variable as a int
    public GameObject coin; //create a game object variable for the collision
    // Start is called before the first frame update
    void Start()
    {
        counter = 0; //declares the starting value of the counter to be 0

    }
    void OnCollisionEnter(Collision other) //built in unity fuction for 3D collisions
    {
        if(other.gameObject.tag=="Player"){ //if the object detects a collision from a object with a tag of player...
            counter++; //adds one to the counter 
            Debug.Log("DING"); //used to test if the collsion works (puts ding into console everytime the item hits)
            Destroy(coin); //destroy the coin after impact
        }
    }
    
}
