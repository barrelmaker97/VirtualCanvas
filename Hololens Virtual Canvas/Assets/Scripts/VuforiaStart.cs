using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VuforiaStart : MonoBehaviour {

    private void Start()
    {
        VuforiaRuntime.Instance.InitVuforia();
    }
}
