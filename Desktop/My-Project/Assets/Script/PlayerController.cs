using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public LayerMask movementMask;
    Camera cam;
    PlayerMotor motor;
    void Start()
    {
        cam = Camera.main;
        motor = GetComponent<PlayerMotor>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit, 100, movementMask))
            {
                // Moves player to object
                motor.MoveToPoint(hit.point);
                // Moves Player around
            }
        if (Input.GetMouseButtonDown(1))
        {
            // Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            // RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100, movementMask))
            {
                // Checks if we hit a interactable
            }
        }
    }
    }
}