using TMPro;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float _Xspeed = 0.025f;
    [SerializeField] public float _Yspeed = 45f;
    [SerializeField] private float _speedModifier = 0.025f;
    [SerializeField] private string _speedPowerUp = "Speed PowerUp";
    [SerializeField] private string _slownessPowerUp = "Slowness PowerUp";
    

    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        float X = 0;
        float Y = 0;
        //float Z = -1;
        if (Input.GetKey(KeyCode.W))
        {
            print("ik heb W ingedrukt");
            transform.Translate(Vector3.up * _Yspeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.A))
        {
            print("Ik heb A ingedrukt");
            Vector3 position = new Vector3(X = (_Xspeed), Y, 0);
            transform.position -= position;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            print("Ik heb D ingedrukt");
            Vector3 position = new Vector3(X = (_Xspeed), Y, 0);
            transform.position += position;
        }
        if (Input.GetKey(KeyCode.R))
        {
            print("Ik heb R ingedrukt");
            quaternion rotation = new(0, 0, 0, 0);
            transform.rotation = rotation;
        }
    }

        private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(_speedPowerUp))
        {
            Destroy(collision.gameObject);
            _Xspeed = _Xspeed + _speedModifier;
        }
        if (collision.gameObject.CompareTag(_slownessPowerUp))
        {

            Destroy(collision.gameObject);
            _Xspeed = (float)((float)_Xspeed - _speedModifier + 0.01);
        }

    }
}

