using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulateObjects : MonoBehaviour {
    // 1. What do I generate? How many copies?
    public GameObject prefab;
    public int numberOfCoppies = 10;

    public float minimumXPosition = -7, maximumXPosition = 7;
    public float minimumYPosition = -4, maximumYPosition = 3;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(transform.name);
        // 2. Loop once per copy
        // - indexer (which iteration in the loop we are in?)
        // - exit condition (when do we stop?)
        // - change indexer at the end of the block
        // i = i + 1 
        // i += 1
        // i++
        for (int i = 0; i < numberOfCoppies; i++) {
            // 3. Create a copy
            // copy the object
            GameObject instance = Instantiate(prefab);
            // parent it under our transform.
            instance.transform.SetParent(transform);
            // rename objects
            instance.name = "PlacedObject-" + i;

            // 4. Place object randomly on the screen
            // create position vector
            Vector2 randomPosition;
            // generate random position within acceptable range
            randomPosition = new Vector2(
                Random.Range(minimumXPosition, maximumXPosition),
                Random.Range(minimumYPosition, maximumYPosition)
            );
            // assign new position to the current object
            instance.transform.position = randomPosition;
        }
    }
}
