using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PushBlockevents : MonoBehaviour
{
    [SerializeField] private string _Death = "deathblock";
    [SerializeField] private string _button = "PushBlockButton";
    [SerializeField] private GameObject _blockToDestroy;
    [SerializeField] private GameObject _blockToDestroy1;
    [SerializeField] private AudioClip _DestroySound;
    [SerializeField] private float _respawnYblock = 16.12177f;
    [SerializeField] private float _respawnXblock = 28.61282f;
    [SerializeField] private string _destoryableBlock = "DestroyablePlatform";
    [SerializeField] private string _triggerblock = "TriggerBlock";

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
            AudioSource.PlayClipAtPoint(_DestroySound, transform.position);
        }
        if (collision.gameObject.CompareTag(_Death))
        {
            Vector3 position = new Vector3(_respawnXblock, _respawnYblock, -1f);
            transform.position = position;
            Quaternion rotation = new(0, 0, 0, 0);
            transform.rotation = rotation;
        }
        if (collision.gameObject.CompareTag(_destoryableBlock))
        {
            Destroy(collision.gameObject);
        }
    }
}

