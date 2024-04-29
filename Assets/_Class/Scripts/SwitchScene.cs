using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour {
    public string sceneToSwitch;

    public void Switch() {
        SceneManager.LoadScene(sceneToSwitch);
    }
}
