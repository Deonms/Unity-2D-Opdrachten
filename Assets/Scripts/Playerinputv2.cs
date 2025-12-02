using UnityEngine;

public class Playerinputv2 : MonoBehaviour
{
    [SerializeField] private string _cointag = "coin";
    [SerializeField] private string _Death = "deathblock";
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
        if (collision.gameObject.CompareTag(_cointag))
        {
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.CompareTag(_Death))
        {
            Vector3 position = new Vector3(2.076958f, 0.2249999f, -1f);
            transform.position = position;
        }
    }
}
