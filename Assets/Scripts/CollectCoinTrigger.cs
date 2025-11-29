using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ParticleSystemJobs;

public class CollectCoinTrigger : MonoBehaviour
{
    public ParticleSystem particleSystema;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            particleSystema.Play();
            Destroy(gameObject, 0.2f);
        }
    }

    void Start()
    {
        
    }

    void Update()
    {

    }
}

    
