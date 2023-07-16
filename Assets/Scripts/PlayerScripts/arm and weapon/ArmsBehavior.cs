using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmsBehavior : MonoBehaviour
{
     
    private void Update()
    {

        // Get the cursor position in world space
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        cursorPosition.z = transform.position.z; // Match the Z position of the GameObject

        // Calculate the direction from the GameObject to the cursor position
        Vector3 direction = cursorPosition - transform.position;
        direction.Normalize();

        // Calculate the angle in degrees between the GameObject's forward direction and the calculated direction
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Rotate the GameObject to face the cursor position
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
