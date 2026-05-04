using UnityEngine;

public class DragToolsScript : MonoBehaviour
{
  
    public bool dragging = false;
    public Vector3 offset;
    public Rigidbody2D RB;
    public Vector3 startPosition;
    public GameObject canvas;

    private void Start()
    {
        startPosition = transform.position;
        RB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(dragging)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
            RB.MovePosition(mousePos);

        }
    }

    public virtual void OnMouseDown()
    {
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        dragging = true;
        transform.SetParent(canvas.transform);
    }
    public virtual void OnMouseUp()
    {
        dragging = false;
        transform.position = startPosition;
        
    }

   

}
