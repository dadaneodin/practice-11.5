using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZoneUnderLvl : MonoBehaviour
{
    public GameObject player;
    public ParticleSystem particleSystema;

    void ReloadScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
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
