using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class PlatformSpawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private string _player = "Player";
    [SerializeField] private GameObject _PlatformPrefab;
    [SerializeField] private List<Transform> _PlatformSpawnLocations = new List<Transform>();
    [SerializeField] private List<Transform> _DeleteonTrigger = new List<Transform>();
    private int _maximumPlatofrmSpawning = 0;
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
        if (collision.gameObject.CompareTag(_player) && _maximumPlatofrmSpawning == 0)
        {
            foreach (Transform location in _PlatformSpawnLocations)
            {
                Instantiate(_PlatformPrefab, location.position, location.rotation);
                _maximumPlatofrmSpawning = _maximumPlatofrmSpawning + 1;
            }
        }
        
        foreach (Transform location in _DeleteonTrigger)
        {
            Destroy(location.gameObject);
        }
    }
}
