using System.Collections.Generic;
using UnityEngine;

public class CoinSpawnOnTrigger : MonoBehaviour
{
    [SerializeField] private string _player = "Player";
    [SerializeField] private GameObject _coinPrefab;
    [SerializeField] private List<Transform> _CoinSpawnLocationsOnTrigger = new List<Transform>();
    private int _maximumCoinSpawning = 0;
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
        if (collision.gameObject.CompareTag(_player) && _maximumCoinSpawning == 0)
            { 
            foreach (Transform location in _CoinSpawnLocationsOnTrigger)
            {
                Instantiate(_coinPrefab, location.position, location.rotation);
                _maximumCoinSpawning = _maximumCoinSpawning + 1;
            }
        }
        }
    }
