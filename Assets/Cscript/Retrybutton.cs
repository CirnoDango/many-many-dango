using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RestartGame : MonoBehaviour
{
    // Method to restart the scene
    public void RestartScene()
    {
        // Get the current scene name
        string currentSceneName = SceneManager.GetActiveScene().name;

        // Reload the scene
        SceneManager.LoadScene(currentSceneName);
    }
}
