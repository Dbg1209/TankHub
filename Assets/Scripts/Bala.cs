using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float velocidad;
    void Update()
    {
        transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
    }

	private void OnTriggerEnter(Collider o)
	{
		if (o.CompareTag("Player"))
		{
			Destroy(gameObject);
		}
	}
}
