using System;
using UnityEngine;

public class PushBlockevents : MonoBehaviour
{
    [SerializeField] private string _Death = "deathblock";
    [SerializeField] private string _button = "PushBlockButton";
    [SerializeField] private GameObject _blockToDestroy;
    [SerializeField] private GameObject _blockToDestroy1;
    private float _respawnYblock = 16.12177f;
    private float _respawnXblock = 28.61282f;
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
            Destroy(_blockToDestroy);
            Destroy(_blockToDestroy1);
        }
        if (collision.gameObject.CompareTag(_Death))
        {
            Vector3 position = new Vector3(_respawnXblock, _respawnYblock, -1f);
            transform.position = position;
            Quaternion rotation = new(0, 0, 0, 0);
            transform.rotation = rotation;
        }
    }
    }

