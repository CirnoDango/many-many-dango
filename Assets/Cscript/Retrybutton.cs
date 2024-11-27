using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RestartGame : MonoBehaviour
{
    public GameObject nextday;
    // Method to restart the scene
    public void RestartScene()
    {
        // Get the current scene name
        string currentSceneName = SceneManager.GetActiveScene().name;

        // Reload the scene
        SceneManager.LoadScene(currentSceneName);
    }
    public void Nextday()
    {
        if (Map.instance.time % 1440 == 0) { Map.instance.Time(1440); }
        Map.instance.Time(1440 - Map.instance.time % 1440);
        nextday.SetActive(false);
    }
}
