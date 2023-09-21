using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public GameObject prefab;
    public float startTime;
    public float endTime;
    public float spawnRate;
    public float delay;

    // Start is called before the first frame update
    void Start()
    {
        WaveManager.instance.waves.Add(this);
        InvokeRepeating("Spawn", startTime, spawnRate);
        Invoke("EndSpawner", endTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        GameObject clone = Instantiate(prefab, transform.position, transform.rotation);
        Destroy(clone, delay);
    }

    void EndSpawner()
    {
        WaveManager.instance.waves.Remove(this);
        CancelInvoke();
    }
}
