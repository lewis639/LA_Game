using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CameraFollow : MonoBehaviour
{
    public Transform target; // Reference to the player's transform
    public float smoothSpeed = 0.125f; // Speed at which the camera follows the player
    public Vector3 offset; // Offset from the player's position
 
    private Vector3 desiredPosition;
 
    void LateUpdate()
    {
        if (target != null)
        {
            desiredPosition = target.position + offset;
            desiredPosition.z = transform.position.z; // Keep the original Z position of the camera
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }
    }
}
