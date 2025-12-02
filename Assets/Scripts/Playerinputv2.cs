using TMPro;
using UnityEngine;

public class Playerinputv2 : MonoBehaviour
{
    [SerializeField] private string _cointag = "coin";
    [SerializeField] private string _Death = "deathblock";
    [SerializeField] private int _scoreboard;
    [SerializeField] private float _respawnY = 0.2249999f;
    [SerializeField] private float _respawnX = 2.076958f;
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
            Vector3 position = new Vector3(_respawnX, _respawnY, -1f);
            transform.position = position;
        }
    }
}
