using TMPro;
using Unity.Mathematics;
using UnityEngine;

public class Playerinputv2 : MonoBehaviour
{
    [SerializeField] private string _cointag = "coin";
    [SerializeField] private string _Death = "deathblock";
    [SerializeField] private int _scoreboard;
    [SerializeField] public float _respawnY = 0.2249999f;
    [SerializeField] public float _respawnX = 2.076958f;
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
            quaternion rotation = new(0, 0, 0, 0);
            transform.rotation = rotation;
        }
    }
}
