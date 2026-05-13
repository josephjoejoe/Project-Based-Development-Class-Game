using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PipeField : MonoBehaviour
{
    public bool Connected = false;
    public BoxCollider2D LeftC;
    public BoxCollider2D RightC;
    
    public bool LeftCon;
    public bool RightCon;

    public AudioSource Pin;
    public AudioClip place;
    

    
    public void Start()
    {
        
       // Object.FindFirstObjectByType<GameManage>().AddPipe(gameObject);
      GameManage.Instance.AddPipe(gameObject);
      Pin.PlayOneShot(place);
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
       if(LeftC.IsTouching(other))
        {
            if(other.CompareTag("Pipe")){
            PipeField pip = other.GetComponent<PipeField>();
            if(pip!= null)
                {
                    if(pip.PipeCompatible())
                    {
                        Connected = true;
                    }
                }
            LeftCon = true;
            Debug.Log("L touch");
            }
            else if(other.CompareTag("Stove"))
            {
                Connected = true;
            }
        }

        if(RightC.IsTouching(other))
        {
            if(other.CompareTag("Pipe")){
                PipeField pip = other.GetComponent<PipeField>();
            if(pip!= null)
                {
                    if(pip.PipeCompatible())
                    {
                        Connected = true;
                    }
                }
            RightCon = true;
            Debug.Log("R touych");
            }
            else if(other.CompareTag("Stove"))
            {
                Connected = true;
            }
        }
        
      
    }

public void OnTriggerExit2D(Collider2D other)
    {
        if(LeftC.IsTouching(other))
        {
            LeftCon = false;
        }

        if(RightC.IsTouching(other))
        {
            RightCon = false;
        }
        
    }
    public bool PipeCompatible()
    {
        if(Connected){
        return true;
        }
        else
        {
            return false;
        }
        
    }
   
    
    
    
}
