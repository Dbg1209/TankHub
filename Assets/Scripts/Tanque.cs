using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tanque : MonoBehaviour
{
    public float velocidad;
    public float velRotacion;

    public Transform cannon;
    public GameObject disparo;

    Rigidbody rb;

	private void Start()
	{
        rb = GetComponent<Rigidbody>();
	}

	void Update()
    {
        rb.velocity = (velocidad * transform.forward * Input.GetAxis("Vertical") + rb.velocity.y*Vector3.up);
        transform.Rotate(0, velRotacion * Time.deltaTime * Input.GetAxis("Horizontal"), 0);
		if (Input.GetKeyDown(KeyCode.Space))
		{
            Instantiate(disparo, cannon.position, cannon.rotation);
		}
    }
}
