using UnityEngine;

public class PipeDragMechanic : MonoBehaviour
{

    bool dragging = false;

    public Vector3 offset;

    public GameObject pipeBar;
    public GameObject canvas;
    public Rigidbody2D RB;

    public Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position; //Store the position the tool is at
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dragging == true)
        {   //Move object, taking into account original offest
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
            RB.MovePosition(mousePos); // be able to move the object with physics 
            pipeBar.SetActive(false); // makes the pipe bar go away when dragging tool
        }
    }

    private void OnMouseDown()
    {   //Record the difference between the objects centre, and the clicked point on the camera plane
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        dragging = true;
        transform.SetParent(canvas.transform); //put the tool in the canvas  
    }

    private void OnMouseUp()
    {
        dragging = false; //stop dragging
        
        //transform.SetParent(pipeBar.transform); //makes the tool go back to the toolbar
    }
}
