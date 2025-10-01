using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildBall.Inputs {
[RequireComponent(typeof(Rigidbody))]

public class PlayerInput : MonoBehaviour
{
    private Rigidbody playerRb;

    private void Awake()
        {
            playerRb = GetComponent<Rigidbody>()        ;
        }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
            Debug.Log("[A] pressed");


        Debug.Log(Input.GetAxis(GlobalStingVars.HORIZONTAL_AXIS));
    }
}
}
