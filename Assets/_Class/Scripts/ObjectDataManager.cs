using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Library for TextMeshPro Componenets
using UnityEngine.UI; // Library for UI Components

public class ObjectDataManager : MonoBehaviour
{
    // 1. List of all of my data
    public List<ObjectData> objectCollection;
    // 2. Which template to use for each object?
    public GameObject prefab;

    private void Start() {
        // 3. When the game starts,
        foreach (ObjectData item in objectCollection) {
            //      - generate one clone of template per object
            GameObject itemInstance = Instantiate(prefab);
            //      - put it as a child of the manager
            itemInstance.transform.SetParent(transform);
            itemInstance.name = item.objectName;
            //      - fill in all the information
            // 1) look for a child with a specific name (case sensitive)
            // 2) from this child find necessary component
            // 3) from this component change the content
            // - name
            Transform nameTransform = itemInstance.transform.Find("NameLabel");
            TextMeshProUGUI nameLabel = nameTransform.GetComponent<TextMeshProUGUI>();
            nameLabel.SetText(item.objectName);
            // - description
            Transform descriptionTransform = itemInstance.transform.Find("Description");
            TextMeshProUGUI descriptionLabel = descriptionTransform.GetComponent<TextMeshProUGUI>();
            descriptionLabel.SetText(item.objectDescription);
            // - image
            Transform imageTransform = itemInstance.transform.Find("Image");
            Image imageComponent = imageTransform.GetComponent<Image>();
            imageComponent.sprite = item.objectImage;
        }
    }
}
