using UnityEngine;

public class PushBlockevents : MonoBehaviour
{
    [SerializeField] private string _button = "PushBlockButton";
    [SerializeField] private string _destroywall = "DestroyPushwall1";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(_button))
        {

        }
    }
}
