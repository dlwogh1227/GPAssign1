using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject prefab;
    public GameObject prefab2;
    public GameObject shootpoint;
    public float delay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject clone = Instantiate(prefab);
            clone.transform.position = shootpoint.transform.position;
            clone.transform.rotation = shootpoint.transform.rotation;
            Destroy(clone, delay);
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            GameObject clone = Instantiate(prefab2);
            clone.transform.position = shootpoint.transform.position;
            clone.transform.rotation = shootpoint.transform.rotation;
            Destroy(clone, delay);
        }
    }
}
