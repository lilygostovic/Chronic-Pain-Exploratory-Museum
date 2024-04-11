using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ImageClickHandler : MonoBehaviour
{
    [SerializeField] private GameObject button; // Reference to the button game object

    private void Start()
    {
        // Ensure the button reference is set in the Inspector
        if (button == null)
        {
            Debug.LogError("Button reference is not set!");
            enabled = false; // Disable the script if the button reference is not set
        }
    }

    private void OnEnable()
    {
        // Subscribe to the interact event of the XR controller
        GetComponent<XRGrabInteractable>().selectEntered.AddListener(OnImageClicked);
    }

    private void OnDisable()
    {
        // Unsubscribe from the interact event when the script is disabled or destroyed
        GetComponent<XRGrabInteractable>().selectEntered.RemoveListener(OnImageClicked);
    }

    private void OnImageClicked(SelectEnterEventArgs args)
    {
        // Make the button invisible when the image is clicked
        button.SetActive(false);
    }
}
