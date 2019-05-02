using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class GetCubeSize : MonoBehaviour {

    private GameObject canvas;
    private Transform trans;
    private TextMesh display;

	// Use this for initialization
	void Start ()
    {
        canvas = this.transform.parent.gameObject;
        trans = canvas.transform;
        display = this.GetComponent<TextMesh>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        double width = Math.Round(trans.localScale.x * 100, 1);
        double height = Math.Round(trans.localScale.y * 100, 1);
        double depth = Math.Round(trans.localScale.z * 100, 1);
        display.text = "Width: " + width.ToString() + "cm" + "\nHeight: " + height.ToString() + "cm" + "\nDepth: " + depth.ToString() + "cm";
	}
}
