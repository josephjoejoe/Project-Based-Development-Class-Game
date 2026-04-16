using UnityEngine;

public class DragMechanic : MonoBehaviour
{

    bool dragging = false;

    public Vector3 offset;

    public GameObject toolBar;
    public GameObject canvas;
    public Rigidbody2D RB;
    public GameObject goodResult;
    public GameObject badResult;

    public Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position; //Store the position the tool is at
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(dragging == true)
        {   //Move object, taking into account original offest
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
            RB.MovePosition(mousePos); // be able to move the object with physics 
            toolBar.SetActive(false); // makes the tool bar go away when dragging tool
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
        transform.position = startPosition; //brings the tool back to its original spot
        transform.SetParent(toolBar.transform); //makes the tool go back to the toolbar
        goodResult.SetActive(false);// makes sure the results dont show when not dragging
        badResult.SetActive(false); 
    }
}
