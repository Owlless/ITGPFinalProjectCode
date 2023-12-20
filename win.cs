using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TryAgain : MonoBehaviour
{
    private void OnCollisionEnter(Collision other){ //Built in unity method utilizer collisions
        if(other.gameObject.tag == "Player") //if the object hits anything with a tag of "Player"
        { 
            SceneManager.LoadScene("Win"); //load the Win scene when you Finish
        }
    }
}
