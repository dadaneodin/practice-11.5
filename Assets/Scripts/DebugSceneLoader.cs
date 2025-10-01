using UnityEngine;
using UnityEngine.SceneManagement;

public class DebugSceneLoader : MonoBehaviour
{
    void Start()
    {
        // Эта надпись появится в консоли когда сцена загрузится
        Debug.Log("Сцена загрузилась: " + SceneManager.GetActiveScene().name);
    }
}