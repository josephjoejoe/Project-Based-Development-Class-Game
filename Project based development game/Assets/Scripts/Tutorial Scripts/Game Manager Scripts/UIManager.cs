using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject toolBar;
    public GameObject pipeEditor;


    // Update is called once per frame
    void Update()
    {

    }

    public void ToggleToolBar()
    {
        toolBar.SetActive(!toolBar.activeSelf); // if tool bar is off turn on and if tool bar is on turn off
    }

    public void TogglePipeEditor()
    {
        pipeEditor.SetActive(!pipeEditor.activeSelf);
    }

}
