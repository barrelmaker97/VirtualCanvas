﻿using UnityEngine;

public class RotateObject : MonoBehaviour {

    public Vector3 speed;

	private void Update ()
    {
        transform.Rotate(speed);
    }
}
