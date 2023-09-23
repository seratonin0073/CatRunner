using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private float period = 2f;
    [SerializeField] private GameObject CoinPref;
    void Start()
    {
        InvokeRepeating("Spawn", 3f, period);
    }
    void Spawn()
    {
        Instantiate(CoinPref, transform.position, Quaternion.identity);
    }
}
