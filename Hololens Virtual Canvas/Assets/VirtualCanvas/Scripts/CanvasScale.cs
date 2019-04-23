using System;
using UnityEngine;

public class CanvasScale : MonoBehaviour {
    public GameObject object1;
    public GameObject object2;

	// Update is called once per frame
	void Update () {
        Vector3 pos1 = object1.transform.position;
        Vector3 pos2 = object2.transform.position;
        Vector3 between = pos1 - pos2;
  
        float xDist = Math.Abs(between.x);
        float yDist = Math.Abs(between.y);
        float zDist = Math.Abs(between.z);
        transform.localScale = new Vector3(xDist, yDist, zDist);
        transform.position = pos1 - (between / 2.0F);
    }
}
