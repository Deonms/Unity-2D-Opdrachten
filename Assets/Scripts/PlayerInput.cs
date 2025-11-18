using Unity.Mathematics;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float X = 0;
        float Y = 0;
        float Z = -1;
        if (Input.GetKey(KeyCode.W))
        {
            Y = (float)(+ 0.5);
            print("ik heb W ingedrukt");
            Vector3 position = new Vector3(X, Y, Z);
            transform.position = new Vector3(X, Y, Z);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            
            Y = (float)(- 0.5);
            print("Ik heb S ingedrukt");
            Vector3 position = new Vector3(X, Y, Z);
            transform.position = new Vector3(X, Y, Z);
        }
        if (Input.GetKey(KeyCode.A))
        {
            X = (float)(- 0.5);
            print("Ik heb A ingedrukt");
            Vector3 position = new Vector3(X, Y, Z);
            transform.position = new Vector3(X, Y, Z);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            X = (float)(+ 0.5);
            print("Ik heb D ingedrukt");
            Vector3 position = new Vector3(X, Y, Z);
            transform.position = new Vector3(X, Y, Z);
        }
    }
}
