using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class CanvasScale : MonoBehaviour {

    public Vector3 Vec1;
    public Vector3 Vec2;
    public Transform target;

	// Use this for initialization
	void Start () {
		Vector3 between = Vec2 - Vec1;
        float xDist = Math.Abs(between.x);
        float yDist = Math.Abs(between.y);
        float zDist = Math.Abs(between.z);
        transform.localScale += new Vector3(xDist, yDist, zDist);
        transform.position = Vec1 + (between / 2.0F);
        transform.LookAt(target);
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(target);
    }
}
