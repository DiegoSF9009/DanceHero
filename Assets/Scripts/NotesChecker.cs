using UnityEngine;

public class NotesChecker : MonoBehaviour
{
    [SerializeField]

    private string checkAnimationName = "Check";

    private GameObject currentNote;
    
    private Animator animator;
    
    public void Awake()
    {
        animator = gameObject.GetComponent<Animator>();
    }

     private void OnTriggerEnter(Collider other)
    
    {
        if (other.CompareTag("Note") && currentNote == other.gameObject)
        {
            
            currentNote = null;
        }


    }

    private void OnTriggerExit(Collider other)
    {
        
        if (other.CompareTag("Note") && currentNote == other.gameObject)
        {
            
            currentNote = null;

        }

    }

    public void Check()
    {
        
        animator.Play(checkAnimationName);
        if (currentNote != null)
        {
            
            Destroy(currentNote);
            currentNote = null;

        }

    }


}
