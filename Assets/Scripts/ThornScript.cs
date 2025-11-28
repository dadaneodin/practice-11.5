using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThornScript : MonoBehaviour
{

    public GameObject player;
    public ParticleSystem particleSystema;

    void ReloadScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }


    public void OnCollisionEnter(Collision collision)
{
        if (collision.gameObject.CompareTag("Player"))
        {
            // Получаем игрока из столкновения
            GameObject player = collision.gameObject;
            
            player.SetActive(false);

            particleSystema.Play();

            // Debug.Log("SceneManager.LoadScene(0);");

            Invoke("ReloadScene", 0.8f);
        }
}
}
