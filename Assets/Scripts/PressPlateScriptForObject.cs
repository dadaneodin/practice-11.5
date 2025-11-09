using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PressPlateScriptForObject : MonoBehaviour
{
    public GameObject ObjectToActivate;
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("TGGObject"))
        {
            ObjectToActivate.SetActive(true);
        }
    }

    // public void OriggerEnter(Collider other)
    // {
    //     if (other.gameObject.CompareTag("TGGObject"))
    //     {
    //         ObjectToActivate.SetActive(true);
    //     }
    // }
}
