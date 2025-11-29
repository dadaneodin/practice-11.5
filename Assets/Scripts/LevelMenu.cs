using UnityEngine;
using UnityEngine.UI;

public class LevelMenu : MonoBehaviour
{
    public Button level1;
    public Button level2;
    public Button level3;
    public Button level4;

    void Start()
    {
        level1.interactable = true;
        level2.interactable = PlayerPrefs.GetInt("Level1Completed", 0) == 1;
        level3.interactable = PlayerPrefs.GetInt("Level2Completed", 0) == 1;
        level4.interactable = PlayerPrefs.GetInt("Level3Completed", 0) == 1;
    }
}
