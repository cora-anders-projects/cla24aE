using UnityEngine;

public class DisableDamageZoneOnSaberEnter : MonoBehaviour
{
    public string targetObjectName = "wooden_handle_saber_1k";

    private string targetObjectTag = "Sword";

    public GameObject enemy;

    private void Start()
    {
        enemy = this.gameObject.transform.parent.gameObject;
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == targetObjectTag)
        {
            Debug.Log("Saber entered, disabling DamageZone.");
            enemy.SetActive(false);
        }
    }
}
