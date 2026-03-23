using UnityEngine;

public class PipeConnectors : MonoBehaviour
{
    public GameObject[] tiles; // store gameobjects that have the tag Tile
    public float snapDistance = 1; // how close the pipe needs to be to snap
    public PipeDragMechanic PDM;

    public bool onPipeBar = true; // check if the pipe is on the pipe bar

    private void Start()
    {
        tiles = GameObject.FindGameObjectsWithTag("Tile"); // find gameobjects with Tile tag
        PDM = GetComponent<PipeDragMechanic>();
    }

    private void Update()
    {
        if (PDM.dragging == true) // getting bool from PipeDragMechanic script
        {
            onPipeBar = false;
        }

        if(onPipeBar == false && PDM.dragging == false) // if pipe is getting dragged
        {
            SnapToNearestTile(); //snap the pipe to the nearest tile
        }
    }

    void SnapToNearestTile()
    {
        GameObject closestTile = null; //store the closest tile we find 
        float closestDistance = Mathf.Infinity; // Start with a very large number so any real distance is smaller


        foreach (GameObject tile in tiles) // loop through every tile in the scene
        {
            float dist = Vector2.Distance(transform.position, tile.transform.position); // calculate the distance between the pipeand this tile

            if(dist < snapDistance) // check if this tile is within snapping distance
            {
                //store this tile as the closest one
                closestDistance = dist;
                closestTile = tile;
            }
        }

        // Snap only if close enough
        if (closestTile != null && closestDistance < snapDistance) 
        {
            transform.position = closestTile.transform.position; // snap pipe into tiles exact position 
        }
    }

}