using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BallThrower : MonoBehaviour
{
    public float throwSpeed = 10f;
    public float throwAngle = 45f;
    public Rigidbody ball;
    public Material trailMaterial;
    private Vector3 initialPosition;
    private bool canThrow = true;

    //Input Fields link
    public TMP_InputField speedInputField;
    public TMP_InputField angleInputField;
    public Toggle stopOnGroundToggle;

    void Start()
    {
        if (ball != null)
        {
            initialPosition = ball.transform.position;
        }
    }

    void Update()
    {
        
        float.TryParse(speedInputField.text, out throwSpeed);
        float.TryParse(angleInputField.text, out throwAngle);

        if (Input.GetKeyDown(KeyCode.Space) && canThrow)
        {
            ThrowBall();
            canThrow = false;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartBall();
        }
    }

    public void ThrowBall()
    {
        if (ball == null)
        {
            Debug.LogError("No ball selected!");
            return;
        }

        float angleInRadians = throwAngle * Mathf.Deg2Rad;
        float velocityX = throwSpeed * Mathf.Cos(angleInRadians);
        float velocityY = throwSpeed * Mathf.Sin(angleInRadians);
        Vector3 throwVelocity = new Vector3(velocityX, velocityY, 0f);

        
        ball.linearVelocity = throwVelocity;

        TrailRenderer trail = ball.gameObject.AddComponent<TrailRenderer>();
        trail.material = trailMaterial;
        trail.widthMultiplier = 0.5f;
        trail.time = 200f;
    }

    public void RestartBall()
    {
        if (ball == null)
        {
            Debug.LogError("No ball!");
            return;
        }

        ball.linearVelocity = Vector3.zero;
        ball.angularVelocity = Vector3.zero;
        ball.transform.position = initialPosition;
        ball.transform.rotation = Quaternion.identity;
        Destroy(ball.GetComponent<TrailRenderer>());

        canThrow = true;
    }

    
}