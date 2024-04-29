using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchSceneOnDelay : SwitchScene {
    // 1. How long do we need to wait? What is the scene we need to switch to?
    public float delayToWait = 10;
    float startTime;

    private void Start() {
        // remember when do we start the scene since the beginning of the game.
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update() {
        // 2. Check if the time in game has passed the required amount
        //      2.1 No: we do nothing.
        //      2.2 Yes: switch the scene.
        // get the time since the start of the scene (not the game).
        float timeSinceStart = Time.time - startTime;
        // print to the console
        Debug.Log(timeSinceStart);
        // check if enough time has passed
        /*
        if (timeSinceStart < delayToWait) {
            // not enough time has passed
        }
        else { 
            // enough time has passed
            // switch to the other scene
            SceneManager.LoadScene(sceneToSwitch);
        }
        */

        if (timeSinceStart >= delayToWait) {
            // enough time has passed
            // switch to the other scene
            Switch();
        }
    }
}
