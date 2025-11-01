using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PressPlateScript : MonoBehaviour
{
    public GameObject ObjectToActivate;
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ObjectToActivate.SetActive(true);
        }
    }
}
