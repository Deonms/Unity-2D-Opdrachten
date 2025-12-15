using System;
using TMPro;
using Unity.Mathematics;
using UnityEngine;

public class Playerinputv2 : MonoBehaviour
{
    [SerializeField] private string _cointag = "coin";
    [SerializeField] private string _Death = "deathblock";
    [SerializeField] private int _playeramount = 1;
    [SerializeField] private float _respawnY = 0.2249999f;
    [SerializeField] private float _respawnX = 2.076958f;
    [SerializeField] private AudioClip _coinpickup;

    private int _score;
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
        CoinValue coinValue;
        if (collision.gameObject.CompareTag(_cointag) && collision.gameObject.TryGetComponent<CoinValue>(out coinValue))
        {
            _score += coinValue.GetScoreWorth();
            Destroy(collision.gameObject);
            print(_score);
            AudioSource.PlayClipAtPoint(_coinpickup, transform.position);
        }
        if (collision.gameObject.CompareTag(_Death))
        {
            Vector3 position = new Vector3(_respawnX, _respawnY, -1f);
            transform.position = position;
            quaternion rotation = new(0, 0, 0, 0);
            transform.rotation = rotation;
        }

    }
}
