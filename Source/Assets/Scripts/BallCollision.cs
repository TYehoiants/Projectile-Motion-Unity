using UnityEngine;

public class BallCollision : MonoBehaviour
{
    public Rigidbody ball; 
    public BallThrower ballThrower;

    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("ExperimentalGround"))
        {
            if (ballThrower.stopOnGroundToggle.isOn) 
            {
                ball.linearVelocity = Vector3.zero; 
                ball.angularVelocity = Vector3.zero; 
            }
        }
    }
}