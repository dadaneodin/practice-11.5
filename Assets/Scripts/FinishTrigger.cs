using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishTrigger : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // int nextScene = SceneManager.GetActiveScene().buildIndex + 1;
            int currentIndex = SceneManager.GetActiveScene().buildIndex;
            int totalScene = SceneManager.sceneCountInBuildSettings;
            int nextIndex = currentIndex + 1;

            if (nextIndex >= totalScene)
                nextIndex = 0;

            SceneManager.LoadScene(nextIndex);
        }
    }
}
