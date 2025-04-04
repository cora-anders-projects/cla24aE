using UnityEngine;

public class Moveleftright : MonoBehaviour
{
    public float moveSpeed = 5f;      // Speed of movement
    public float moveRange = 10f;     // Maximum distance to move left and right
    private float startPositionX;     // Starting X position of the object
    private bool movingRight = true;  // Direction flag (true = right, false = left)

    void Start()
    {
        // Store the initial position of the object
        startPositionX = transform.position.x;
    }

    void Update()
    {
        // Calculate the new position along the X axis based on the movement range
        float newX = transform.position.x;

        if (movingRight)
        {
            newX += moveSpeed * Time.deltaTime;

            // Check if we have reached the max range to the right
            if (newX - startPositionX >= moveRange)
            {
                movingRight = false;  // Reverse the direction
            }
        }
        else
        {
            newX -= moveSpeed * Time.deltaTime;

            // Check if we have reached the max range to the left
            if (startPositionX - newX >= moveRange)
            {
                movingRight = true;  // Reverse the direction
            }
        }

        // Apply the new position to the object
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }
}

