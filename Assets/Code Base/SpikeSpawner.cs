using System.Collections;
using UnityEngine;

public class SpikeSpawner : MonoBehaviour
{
    public GameObject[] Spikes;
    public float startTime = 1f;
    public float endTime = 2f;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        int rnd = Random.Range(0, 2);
        Instantiate(Spikes[rnd], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(Random.Range(startTime, endTime));
        StartCoroutine(Spawn());
    }
}
