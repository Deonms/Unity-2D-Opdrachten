using TMPro;
using Unity.Mathematics;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float _Xspeed = 0.15f;
    [SerializeField] public float _Yspeed = 45f;
   
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
}
