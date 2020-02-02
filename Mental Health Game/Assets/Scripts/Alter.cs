using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alter : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Standing at alter");

        if(other.gameObject.tag == "Player" && GameVariables.keyCount >0)
        {
            GameVariables.keyCount++;
            //Debug.Log("Current key count: " + GameVariables.keyCount);
            Debug.Log("The alter has been opened.");
        }

        
    }
}
