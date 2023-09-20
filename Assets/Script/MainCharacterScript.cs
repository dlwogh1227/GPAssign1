using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterScript : MonoBehaviour
{
    public float rotationSpeed;
    public float speed;
    private Rigidbody rb;
    // Start is called before the first frame update
    private void Awake()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rb.AddRelativeForce(movementValue * speed * Time.deltaTime, 0, Vector3. * speed * Time.deltaTime);

        //float mouseX = Input.GetAxis("Mouse X");
        //transform.Rotate(0, mouseX * rotationSpeed * Time.deltaTime, 0);
    }
}
