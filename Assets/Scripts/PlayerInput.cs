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
            print("ik heb W ingedrukt");
            Vector3 position = new Vector3(X, (float)(+0.5), Z);
            transform.position = new Vector3(X, Y, Z);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            print("Ik heb S ingedrukt");
            Vector3 position = new Vector3(X, (float)(-0.5), Z);
            transform.position = new Vector3(X, Y, Z);
        }
        if (Input.GetKey(KeyCode.A))
        {
            print("Ik heb A ingedrukt");
            Vector3 position = new Vector3((float)(-0.5), Y, Z);
            transform.position = new Vector3(X, Y, Z);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            print("Ik heb D ingedrukt");
            Vector3 position = new Vector3((float)(+0.5), Y, Z);
            transform.position = new Vector3(X, Y, Z);
        }
    }
}
