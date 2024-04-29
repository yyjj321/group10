using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnGravity : MonoBehaviour
{
    // Iterate on all children and turn on gravity
    public void TurnOnGravityForChildren() {
        // 1. Loop through all of our children
        foreach (Transform child in transform) {
            // 2. Try to get RigidBody2D from them
            Rigidbody2D childRigidBody = child.GetComponent<Rigidbody2D>();
            // 3. Modify gravity scale
            childRigidBody.gravityScale = 1;
        }
    }
}
