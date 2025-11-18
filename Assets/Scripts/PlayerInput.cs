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
        if (Input.GetKey(KeyCode.W))
        {
            print("ik heb W ingedrukt");
        }
        else if (Input.GetKey(KeyCode.S))
        {
            print("Ik heb S ingedrukt");
        }
        if (Input.GetKey(KeyCode.A))
        {
            print("Ik heb A ingedrukt");
        }
        else if (Input.GetKey(KeyCode.D))
        {
            print("Ik heb D ingedrukt");
        }
    }
}
