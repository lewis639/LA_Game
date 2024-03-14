using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class PlayerTeleport : MonoBehaviour
{
    public KeyCode interactKey = KeyCode.E; // Key to trigger the teleport
    public Transform teleportDestinationA; // Destination object A to teleport to
    public Transform teleportDestinationB; // Destination object B to teleport to
    public float teleportRange = 2f; // Range within which the player can teleport
 
    private bool isTeleporting = false; // Flag to prevent repeated teleportation
 
    void Update()
    {
        if (Input.GetKeyDown(interactKey) && !isTeleporting)
        {
            // Check if the player is within range of destination A
            if (Vector3.Distance(transform.position, teleportDestinationA.position) <= teleportRange)
            {
                isTeleporting = true;
                TeleportPlayer(teleportDestinationB);
            }
            // Check if the player is within range of destination B
            else if (Vector3.Distance(transform.position, teleportDestinationB.position) <= teleportRange)
            {
                isTeleporting = true;
                TeleportPlayer(teleportDestinationA);
            }
        }
    }
 
    void TeleportPlayer(Transform destination)
    {
        transform.position = destination.position;
        isTeleporting = false;
    }
}