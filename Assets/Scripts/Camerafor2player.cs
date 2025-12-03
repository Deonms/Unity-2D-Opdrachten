using UnityEngine;

public class Camerafor2player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    // Follow Two Transforms with a Fixed-Orientation Camera
    public void FixedCameraFollowSmooth(Camera maincamera, Transform player1, Transform player2)
    {
        // How many units should we keep from the players
        float zoomFactor = 1.5f;
        float followTimeDelta = 0.8f;

        // Midpoint we're after
        Vector3 midpoint = (player1.position + player2.position) / 2f;

        // Distance between objects
        float distance = (player1.position - player2.position).magnitude;

        // Move camera a certain distance
        Vector3 cameraDestination = midpoint - maincamera.transform.forward * distance * zoomFactor;

        // Adjust ortho size if we're using one of those
        if (maincamera.orthographic)
        {
            // The camera's forward vector is irrelevant, only this size will matter
            maincamera.orthographicSize = distance;
        }

        // You specified to use MoveTowards instead of Slerp
        maincamera.transform.position = Vector3.Slerp(maincamera.transform.position, cameraDestination, followTimeDelta);

        // Snap when close enough to prevent annoying slerp behavior
        if ((cameraDestination - maincamera.transform.position).magnitude <= 0.05f)
            maincamera.transform.position = cameraDestination;
    }
}
