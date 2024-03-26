using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectArtork : MonoBehaviour
{
    // [SerializeField] private GameObject[] interactionButtons;

    // private Vector3 originalScale;
    // private Vector3 originalPosition;
    // private bool isFocused = false;

    void Start()
    {
        // // Store the original scale and position of the object
        // originalScale = transform.localScale;
        // originalPosition = transform.position;


    }

    void Update()
    {
        // if (Input.GetMouseButtonDown(0))
        // {
        //     RaycastHit hitInfo;
        //     Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //     if (Physics.Raycast(ray, out hitInfo))
        //     {
        //         // Check if the clicked object is the artwork
        //         if (hitInfo.collider.gameObject == gameObject)
        //         {
        //             if (!isFocused)
        //             {
        //                 // If the object is not focused, move it 10% closer to the camera
        //                 transform.position = Vector3.Lerp(transform.position, Camera.main.transform.position, 0.1f);
        //                 isFocused = true;

        //                 // Show buttons when focused
        //                 ShowButtons(true);
        //             }
        //         }
        //         else
        //         {
        //             // If the clicked object is not the artwork, reset its position to the original position
        //             transform.position = originalPosition;
        //             isFocused = false;

        //             // Hide buttons when not focused
        //             ShowButtons(false);
        //         }
        //     }
        // }
    }

    // void ShowButtons(bool show)
    // {
    //     foreach (GameObject obj in interactionButtons)
    //     {
    //         obj.SetActive(show);
    //     }
    // }
}
