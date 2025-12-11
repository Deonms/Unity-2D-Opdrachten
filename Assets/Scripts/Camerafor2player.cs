using System;
using System.Runtime.InteropServices;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class Camerafor2player : MonoBehaviour
{
    [SerializeField] private GameObject _player1;
    [SerializeField] private GameObject _player2;
    [SerializeField] private GameObject _maincamera;
    [SerializeField] private float _distance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    // Follow Two Transforms with a Fixed-Orientation Camera
    public void FixedCameraFollowSmooth(Camera _maincamera, Transform _player1, Transform _player2)
    {
        // How many units should we keep from the players
        float zoomFactor = 1.5f;
        float followTimeDelta = 0.8f;

        // Midpoint we're after
        Vector3 midpoint = (_player1.position + _player2.position) / 2f;

        // Distance between objects
        float distance = (_player1.position - _player2.position).magnitude;

        // Move camera a certain distance
        Vector3 cameraDestination = midpoint - _maincamera.transform.forward * distance * zoomFactor;

        // Adjust ortho size if we're using one of those
        if (_maincamera.orthographic)
        {
            // The camera's forward vector is irrelevant, only this size will matter
            _maincamera.orthographicSize = distance;
            
        }

        // You specified to use MoveTowards instead of Slerp
        _maincamera.transform.position = Vector3.Slerp(_maincamera.transform.position, cameraDestination, followTimeDelta);

        // Snap when close enough to prevent annoying slerp behavior
        if ((cameraDestination - _maincamera.transform.position).magnitude <= 0.05f)
            _maincamera.transform.position = cameraDestination;
    }
}
