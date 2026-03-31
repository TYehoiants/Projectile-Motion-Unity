using UnityEngine;
using UnityEngine.UI;

public class CameraScrollbarControl : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private Scrollbar scrollbarX;
    [SerializeField] private Scrollbar scrollbarY;
    [SerializeField] private float minX = -10f, maxX = 10f; 
    [SerializeField] private float minY = -5f, maxY = 5f;   

    private void Start()
    {
        
        scrollbarX.onValueChanged.AddListener(UpdateCameraPosition);
        scrollbarY.onValueChanged.AddListener(UpdateCameraPosition);
    }

    private void UpdateCameraPosition(float value)
    {
        if (mainCamera == null) return;

        // Current pow
        Vector3 newPosition = mainCamera.transform.position;

        
        newPosition.x = Mathf.Lerp(minX, maxX, scrollbarX.value);
        newPosition.y = Mathf.Lerp(minY, maxY, scrollbarY.value);

       
        mainCamera.transform.position = newPosition;
    }
}