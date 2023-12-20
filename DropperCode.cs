using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropperCode : MonoBehaviour
{
    public GameObject obbyDrop; // makesa public game object variable for later use

    public float zDrop=340f; //z original coords decalred as a float
    public float xDrop=-6f; //x original coords decalred as a float
    public float yDrop= 65f; //y original coords decalred as a float
    public int amountOfObj=5; //how mnay objects do you want to be summoned
    void OnCollisionEnter(Collision other){ //built in collision method from unity
        if(other.gameObject.tag=="Player"){ //if it detects a collision from a game object with the tag "Player"
            for(int i = 0; i<amountOfObj; i++ ){ //for loop to control the amount of items summoned in
                Instantiate(obbyDrop,new Vector3(xDrop,yDrop,zDrop), Quaternion.identity); //drop the block using the given coords declared (this is to make the blocks have alternating spawn and space 30 units apart)
                if(i%2==0){ //if the number in the loop is odd
                    xDrop = 4; //make it spawn on right side of the map
                }
                else{ //if its odd
                    xDrop = -6; //make it spawn on the left
                }
                zDrop += 30f; //space it out by 30 blocks on the next spawn        
            }
        }
    }
}