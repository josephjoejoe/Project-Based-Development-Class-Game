using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ExitVentCheck exitVC;
    public StoveCheck stoveCheck;

    //public GameObject pipes;
    //public List<List<GameObject>> pipe = new List<List<GameObject>>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (exitVC.isConnected == true && stoveCheck.isConnected == true)
        {
            Debug.Log("I WIN!!");
        }
    }
}
