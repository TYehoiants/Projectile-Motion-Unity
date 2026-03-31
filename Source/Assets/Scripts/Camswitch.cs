using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;
    public KeyCode switchKey = KeyCode.C; // Switch key

    private bool isCamera1Active = true;

    void Start()
    {
        
        camera1.enabled = true;
        camera2.enabled = false;
    }

    void Update()
    {
        
        if (Input.GetKeyDown(switchKey))
        {
            //Switch cameras
            camera1.enabled = !camera1.enabled;
            camera2.enabled = !camera2.enabled;

            isCamera1Active = !isCamera1Active;
        }
    }
}