using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PalayGaem : MonoBehaviour
{
    public void PalayGaems(){ //method declared to run one script
        SceneManager.LoadScene("DaGaem"); //load the scene names "DaGaem"
    }
    public void QuitGame(){ // method to quit game application
        Application.Quit(); //quits game executable
    }
}
