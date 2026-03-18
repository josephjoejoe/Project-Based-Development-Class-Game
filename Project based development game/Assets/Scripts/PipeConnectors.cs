using UnityEngine;

public class PipeConnectors : MonoBehaviour
{
    public PipeConnectors connectedTo;
    public float snapDistance = 0.5f;


    private void OnTriggerStay2D(Collider2D other)
    {
        PipeConnectors otherConnector = other.GetComponent<PipeConnectors>();

        if (otherConnector != null && otherConnector != this)
        {
            float dist = Vector2.Distance(transform.position, other.transform.position);
            if(dist < snapDistance && connectedTo == null && otherConnector.connectedTo == null) // only able to connect to others if everything is null and  within distance
            {
                SnapTo(otherConnector); // conncect to other connector
            }

        }
    }
    void SnapTo(PipeConnectors other)
    {
        Transform pipe = transform.parent;
        Vector3 offset = transform.position - pipe.position;

        pipe.position = other.transform.position - offset;

        connectedTo = other;
        //other.connectedTo = this;
    }
}
