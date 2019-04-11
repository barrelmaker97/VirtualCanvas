using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using UnityEngine.SceneManagement;
using Vuforia;

public class BackClick : MonoBehaviour, IInputClickHandler
{
    public void OnInputClicked(InputClickedEventData eventData)
    {
        //VuforiaRuntime.Instance.Deinit();
        SceneManager.LoadSceneAsync(0, LoadSceneMode.Single);
    }
}
