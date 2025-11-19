using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class FInishTrigger1 : MonoBehaviour
{
    public GameObject ObjectToActivate;
    // public void OnTriggerEnter(Collision other)
    // {
    //     if (other.gameObject.CompareTag("Player"))
    //     {
    //         ObjectToActivate.SetActive(true);
    //     }
    // }
    
    void OnTriggerEnter(Collider other)
    {
         if (other.gameObject.CompareTag("Player"))
        {
            ObjectToActivate.SetActive(true);
        }
    }
}
