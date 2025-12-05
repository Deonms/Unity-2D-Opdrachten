using System;
using UnityEngine;

public class PushBlockevents : MonoBehaviour
{
    [SerializeField] private string _button = "PushBlockButton";
    [SerializeField] private string _destroywall = "DestroyPushwall1";
    float X = 0;
    float Y = 0;
    [SerializeField] private float _Yspeed = 0.075f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       /*if (Input.GetKey(KeyCode.Z))
        {
            print("ik heb Z ingedrukt");
            Vector3 position = new Vector3(X, Y = (_Yspeed), 0);
            transform.position += position;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(_button))
        {
            Destroy(gameObject.CompareTag(_destroywall));
        }

    }*/
}
