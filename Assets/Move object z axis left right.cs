using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float speed = 2f; // Speed of the movement
    public float distance = 5f; // Maximum distance the object will travel from its starting position

    private Vector3 startPosition;

    void Start()
    {
        // Store the starting position of the object
        startPosition = transform.position;
    }

    void Update()
    {
        // Calculate the new position based on a sine wave for smooth back-and-forth motion
        float newZ = startPosition.z + Mathf.Sin(Time.time * speed) * distance;

        // Set the new position, keeping the same X and Y coordinates
        transform.position = new Vector3(transform.position.x, transform.position.y, newZ);
    }
}


