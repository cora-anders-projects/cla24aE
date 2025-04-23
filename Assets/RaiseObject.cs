using UnityEngine;

public class RaiseObject : MonoBehaviour
{
    [Tooltip("Distance to raise the object when Raise() is called.")]
    public float raiseDistance = 5f;

    // Call this method to raise the object
    public void Raise()
    {
        transform.position += new Vector3(0, raiseDistance, 0);
    }
}
