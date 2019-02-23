using System;
using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class SceneClick : MonoBehaviour, IInputClickHandler {

    public int sceneNumber;

    public void OnInputClicked(InputClickedEventData eventData)
    {
        // Make sure scene exists and then load
        if (sceneNumber < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadSceneAsync(sceneNumber, LoadSceneMode.Single);
        }
    }
}
