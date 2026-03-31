

using UnityEngine;

public class ObjectTeleport : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 spawnPosition = new Vector3(45, 42, 12);
    private Vector3 offscreenPosition = new Vector3(45, -57, 12);
    private bool isSpawned = false; 

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        if (rb == null)
        {
            Debug.LogError("no Rigidbody");
        }

        //Transfer object out of bounce
        transform.position = offscreenPosition;
        rb.isKinematic = true; //-physics
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (!isSpawned)
            {
                // teleport to spawn
                transform.position = spawnPosition;
                rb.isKinematic = true; // +physics
                isSpawned = true;
            }
            else
            {
                // teleport out of bounce
                transform.position = offscreenPosition;
                rb.isKinematic = true; // -physics
                isSpawned = false;
            }
        }

        //Only if object is spawned
        if (isSpawned)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.isKinematic = false;
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                rb.isKinematic = true;
                rb.linearVelocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
                transform.position = spawnPosition;
                rb.isKinematic = true;
            }
        }
    }
}