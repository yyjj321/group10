using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicsOfCoding : MonoBehaviour {
    // Variables:

    // access level (public/private)    type    name    [optionally] = default value;

    // - C# types
    public int myWholeNumber = 10;              // integers
    public float myFloatingPointNumber = 20.5f; // floating point number
    public bool myBoolean = false;              // true or false
    public string myString = "Hello SISD!";     // text
    // - Unity types
    public Color myColor
        = new Color(0.5f, 0, 1);
    public Color myColor2
        = new Color(0.5f, 0, 1);
    public Vector2 myVector = Vector2.one;      // new Vector2(1,1);
    // - Unity reference types
    // this way we connect to existing objects in our scene.
    // anything is a game object
    public GameObject myGameObject;
    // anything has a transform
    public Transform myTransform;
    // only camera will fit here
    public Camera myCamera;
    // only circle colliders will fit here
    public CircleCollider2D myCircleCollider;
    // - collections
    // stays fixed length and order
    public Rigidbody2D[] myArray;
    // can be extended or cleared or adjusted or sorted etc.
    public List<Rigidbody2D> myList;

    // Function (method):
    // access level     return type (void if doesn't return)     name    ([optionally]inputs)

    private void Start() {
        // Special variable to access our game object or our transform
        // gameObject
        // transform
        Debug.Log("This script is attached to: " + gameObject.name);
    }
}
