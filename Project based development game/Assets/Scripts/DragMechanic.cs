using UnityEngine;

public class DragMechanic : MonoBehaviour
{
    bool dragging = false;
    public Vector3 offset;
    public GameObject toolbar;
    
    // Update is called once per frame
    void Update()
    {
        if(dragging == true)
        {   //Move object, taking into account original offest
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
            toolbar.SetActive(false);
        }
    }

    private void OnMouseDown()
    {   //Record the difference between the objects centre, and the clicked point on the camera plane.
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        dragging = true;
        transform.SetParent(null);
    }

    private void OnMouseUp()
    {
        dragging = false; // stop dragging
    }
}
