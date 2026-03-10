using UnityEngine;

public class DragMechanic : MonoBehaviour
{
    bool dragging = false;
    public Vector3 offset;
    public GameObject toolBar;
    public Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position; //Store the position the tool is at
    }

    // Update is called once per frame
    void Update()
    {
        if(dragging == true)
        {   //Move object, taking into account original offest
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
            toolBar.SetActive(false);
        }
    }

    private void OnMouseDown()
    {   //Record the difference between the objects centre, and the clicked point on the camera plane
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        dragging = true;
        transform.SetParent(null); //makes the tool its own parent  
    }

    private void OnMouseUp()
    {
        dragging = false; //stop dragging

        transform.position = startPosition; //brings the tool back to its original spot
        transform.SetParent(toolBar.transform); //makes the tool go back to the toolbar
    }
}
