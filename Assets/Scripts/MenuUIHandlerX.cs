using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField nameInputField; 

    public void StartNew()
    {
        // Get the player's name from the input field
        string playerName = nameInputField.text;

        // Store the player's name in PlayerPrefs for future use (optional)
        PlayerPrefs.SetString("PlayerName", playerName);

        // Load the Main scene
        SceneManager.LoadScene("main");
    }

    public void Exit()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }
}
