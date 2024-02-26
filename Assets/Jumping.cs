using UnityEngine;

public class JumpingObject : MonoBehaviour
{
    public float jumpHeight = 4f;   // Adjust this to set the jump height
    public float jumpFrequency = 1f; // Adjust this to set the jump frequency

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        ApplyJumpingMotion();
    }

    void ApplyJumpingMotion()
    {
        // Calculate the vertical position based on the jump height and frequency
        float verticalPosition = startPos.y + Mathf.Sin(Time.time * jumpFrequency) * jumpHeight;

        // Apply the vertical position to the object
        transform.position = new Vector3(transform.position.x, verticalPosition, transform.position.z);
    }
}
