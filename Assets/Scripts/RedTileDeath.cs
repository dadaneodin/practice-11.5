using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedTileDeath : MonoBehaviour
{
    public GameObject player;
    public ParticleSystem particleSystema;

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.SetActive(false);

            particleSystema.Play();

            // Debug.Log("SceneManager.LoadScene(0);");

            Invoke("ReloadScene", 0.8f);
        }
    }
}
