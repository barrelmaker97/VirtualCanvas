using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using System;

public class GazeReact : MonoBehaviour, IFocusable {

    public Vector3 newRotationSpeed;
    public Material newMaterial;
    public string sceneDescription;

    private RotateObject rotation;
    private Renderer rend;
    private TextMesh titleTextMesh;
    private Vector3 oldRotationSpeed;
    private Material oldMaterial;
    private string oldText;

    private void Awake()
    {
        // Get necessary components
        rotation = gameObject.GetComponent<RotateObject>() as RotateObject;
        rend = gameObject.GetComponent<Renderer>() as Renderer;
    }

    private void Start ()
    {
        // Get Text Mesh from title object if it exists
        GameObject menuTitle = GameObject.FindGameObjectWithTag("Title");
        if (menuTitle != null)
        {
            titleTextMesh = menuTitle.GetComponent<TextMesh>();
        }
    }

    public void OnFocusEnter()
    {
        if (rotation != null)
        {
            // Apply new rotation speed
            oldRotationSpeed = rotation.speed;
            rotation.speed = newRotationSpeed;
        }
        if (rend != null)
        {
            // Apply new material
            oldMaterial = rend.material;
            rend.material = newMaterial;
        }
        if (titleTextMesh != null)
        {
            // Change title text
            oldText = titleTextMesh.text;
            titleTextMesh.text = sceneDescription;
        }
    }

    public void OnFocusExit()
    {
        if (rotation != null)
        {
            // Revert rotation speed
            rotation.speed = oldRotationSpeed;
        }
        if (rend != null)
        {
            // Revert material
            rend.material = oldMaterial;
        }
        if (titleTextMesh != null)
        {
            // Revert title text
            titleTextMesh.text = oldText;
        }
    }
}
