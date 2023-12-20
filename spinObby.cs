using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinObby : MonoBehaviour
{
    float spinSpeed; //decalre a flat value names spinSpeed
    // Start is called before the first frame update
    void Start()
    {
        spinSpeed = 150f; //sets the spin speed to 150
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, spinSpeed * Time.deltaTime); //spin the object at the spin speed along the z axis
    }
}
