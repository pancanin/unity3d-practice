using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;

    private float zRotationInput;

    private const float zRotationStep = 1.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // get the user's vertical input
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Q))
        {
            zRotationInput += zRotationStep;
        } else if (Input.GetKeyDown(KeyCode.E))
        {
            zRotationInput -= zRotationStep;
        }

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed);

        // tilt the plane up/down based on up/down arrow keys
        // turn the plane left or right based on left right keys
        float xRotation = calculateRotationBasedOnInput(-verticalInput);
        float yRotation = calculateRotationBasedOnInput(horizontalInput);
        float zRotation = calculateRotationBasedOnInput(zRotationInput);
        transform.Rotate(xRotation, yRotation, zRotation);
    }

    private float calculateRotationBasedOnInput(float axisForce)
    {
        return axisForce * rotationSpeed * Time.deltaTime;
    }
}
