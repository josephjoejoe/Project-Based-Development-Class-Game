using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class PipeTool2 : DragToolsScript
{
    public GameObject PipePrefab;
    
    public GameObject[] tiles;
    public Vector3 trans;

    public float snapDistance = 1;

    public AudioSource ptool;
    public AudioClip tpickup;

    
    public override void OnMouseUp()
    {
         
        SnapToNearestTile();
        trans.x = transform.position.x;
        trans.y = transform.position.y;
        Instantiate(PipePrefab, trans, Quaternion.Euler(0,0,-90));
        
        //Add a function that adds the pipe prefab to a list that records all played pipes
        transform.position = startPosition; 
        dragging = false;

    }

    public override void OnMouseDown()
    {
        base.OnMouseDown();
        ptool.PlayOneShot(tpickup);
    }

     void SnapToNearestTile()
    {
        GameObject closestTile = null; //store the closest tile we find 
        float closestDistance = Mathf.Infinity; // Start with a very large number so any real distance is smaller


        foreach (GameObject tile in tiles) // loop through every tile in the scene
        {
            float dist = Vector2.Distance(transform.position, tile.transform.position); // calculate the distance between the pipeand this tile

            if (dist < snapDistance) // check if this tile is within snapping distance
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
