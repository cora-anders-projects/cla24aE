using UnityEngine;

public class DisableDamageZoneOnSaberEnter : MonoBehaviour
{
    public string targetObjectName = "wooden_handle_saber_1k";

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == targetObjectName)
        {
            Debug.Log("Saber entered, disabling DamageZone.");
            gameObject.SetActive(false);
        }
    }
}
