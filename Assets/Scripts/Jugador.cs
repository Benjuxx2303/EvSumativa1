using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float velocidad = 20;
    public float salto = 5;
    public float rotacion = 120;
    public float abajo = -10;
    private Rigidbody rigidbody;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        var ejeX = Input.GetAxis("Horizontal");
        var ejeZ = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(ejeX, 0 , ejeZ) * (Time.deltaTime * velocidad));
        var mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(new Vector3(0, mouseX, 0) * (Time.deltaTime * rotacion));

        if (Input.GetKeyDown(KeyCode.Space)) {
            rigidbody.AddForce(new Vector3(0, salto, 0), ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift)) {
            rigidbody.AddForce(new Vector3(0, abajo, 0), ForceMode.Impulse);
        }
    }
}
