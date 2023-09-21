using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
    public GameObject prefab;
    public GameObject prefab2;
    public GameObject shootpoint;
    public float delay;
    // Start is called before the first frame update

    public void OnFire(InputValue value)
    {
        if (value.isPressed)
        {
            GameObject clone = Instantiate(prefab);

            clone.transform.position = shootpoint.transform.position;
            clone.transform.rotation = shootpoint.transform.rotation;
            Destroy(clone, delay);
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
