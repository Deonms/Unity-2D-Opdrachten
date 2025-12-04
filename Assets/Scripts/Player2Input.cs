using Unity.Mathematics;
using UnityEngine;

public class Player2Input : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float _Xspeed = 0.025f;
    [SerializeField] private float _Yspeed = 0.075f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float X = 0;
        float Y = 0;
        //float Z = -1;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            print("ik heb UpArrow ingedrukt");
            Vector3 position = new Vector3(X, Y = (_Yspeed), 0);
            transform.position += position;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            print("Ik heb DownArrow ingedrukt");
            Vector3 position = new Vector3(X, Y = (_Yspeed), 0);
            transform.position -= position;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            print("Ik heb LeftArrow ingedrukt");
            Vector3 position = new Vector3(X = (_Xspeed), Y, 0);
            transform.position -= position;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            print("Ik heb RightArrow ingedrukt");
            Vector3 position = new Vector3(X = (_Xspeed), Y, 0);
            transform.position += position;
        }
        if (Input.GetKey(KeyCode.L))
        {
            print("Ik heb l ingedrukt");
            quaternion rotation = new(0, 0, 0, 0);
            transform.rotation = rotation;
        }

    }
}
