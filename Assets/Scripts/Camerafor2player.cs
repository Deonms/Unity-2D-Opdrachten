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
    public void FixedCameraFollowSmooth(Camera _maincamera, Transform _player1, Transform _player2)
    {
        float zoomFactor = 1.5f;
        float followTimeDelta = 0.8f;

        Vector3 midpoint = (_player1.position + _player2.position) / 2f;

        float distance = (_player1.position - _player2.position).magnitude;

        Vector3 cameraDestination = midpoint - _maincamera.transform.forward * distance * zoomFactor;

        if (_maincamera.orthographic)
        {
            _maincamera.orthographicSize = distance;
            
        }

        _maincamera.transform.position = Vector3.Slerp(_maincamera.transform.position, cameraDestination, followTimeDelta);

        if ((cameraDestination - _maincamera.transform.position).magnitude <= 0.05f)
            _maincamera.transform.position = cameraDestination;
    }
}
