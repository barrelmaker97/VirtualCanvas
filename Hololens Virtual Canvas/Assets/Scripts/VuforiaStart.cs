using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VuforiaStart : MonoBehaviour {

    private void Awake()
    {
        VuforiaRuntime.Instance.InitVuforia();
    }
}
