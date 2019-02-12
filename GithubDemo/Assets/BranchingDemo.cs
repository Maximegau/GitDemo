using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BranchingDemo : MonoBehaviour
{
    private void Start()
    {
        //Added Line Before
        Debug.Log("Test09");
        Debug.Log(gameObject.name);
        //Add Line Middle
        Debug.Log("Line10");
    }
}
