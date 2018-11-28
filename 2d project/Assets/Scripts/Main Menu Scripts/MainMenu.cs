using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public int leveltoLoad;

    public void LoadLevel() {
        SceneManager.LoadScene(leveltoLoad);
    }

    public void LevelExit() {
        Application.Quit();
    }
}
