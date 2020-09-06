using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rigidBody;
    public float forwardForce;
    public float sidewayForce;

    // Start is called before the first frame update
    void Start()
    {
        forwardForce = 6000f;
        sidewayForce = 90f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidBody.AddForce(0, 0, Time.deltaTime * forwardForce);
        if (Input.GetAxis("Horizontal") == 1)
        {
            rigidBody.AddForce(Time.deltaTime * sidewayForce, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetAxis("Horizontal") == -1)
        {
            rigidBody.AddForce(Time.deltaTime * -sidewayForce, 0, 0, ForceMode.VelocityChange);
        }

        if (rigidBody.position.y < 0f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
