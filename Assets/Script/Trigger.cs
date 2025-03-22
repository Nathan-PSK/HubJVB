using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    public Animator animator; 
    public string animationTrigger; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetTrigger(animationTrigger);
        }
    }
}
