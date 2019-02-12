using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BranchingDemo : MonoBehaviour
{
    private void Start()
    {
        //Added Line Before
        Debug.Log("Test09");
        int numbera = 10;
        numbera++;
        Debug.Log(gameObject.transform.position);
        //Add Line Middle
        Debug.Log("Line10");
    }
}
