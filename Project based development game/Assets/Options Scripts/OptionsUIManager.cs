using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsUIManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoBack()
    {
        SceneManager.LoadScene(0); // takes player back to main menu
    }
}
