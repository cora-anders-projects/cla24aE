using UnityEngine;

public class playattack: MonoBehaviour
{
    public string targetTag = "Player"; // Or whatever tag your player uses
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(targetTag))
        {
            animator.SetBool("isPlayerClose", true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(targetTag))
        {
            animator.SetBool("isPlayerClose", false);
        }
    }
}
