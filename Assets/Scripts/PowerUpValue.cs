using UnityEngine;

public class PowerUpValue : MonoBehaviour
{
    [SerializeField] private float _powerUpWorth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public float GetPowerUpWorth()
    {
        return _powerUpWorth;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
