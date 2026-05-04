using UnityEngine;  

public class CheckScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public PipeField Pip;
    public bool Connect = false;
    public bool CheckCollision(Collider2D other)
    {
        if(other.gameObject.CompareTag("Pipe"))
        {
            PipeField OP = other.GetComponent<PipeField>();
            if(OP.PipeCompatible())
            {
                Connect = true;
            }
            else
            {
                Connect = false;
            }
            
        }
        return Connect;
    }
}
