using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mira : MonoBehaviour 
{
	public Transform pato;
	private Rigidbody rb;
	private Vector3 lugarInicio;
	private Quaternion QuaInucio;
	public float poder;
	private float contador = 0.0f;
	public float subir;
	private bool disparado = false;
	void OnMuoseEnter ()
	{
		Debug.Log("enter");
	}

	void OnMouseDown ()
	{
		Debug.Log("down");
		rb.AddRelativeForce (Vector3.down * poder);

		disparado = true;
	
	}



	void Start () 
	{
		rb = GetComponent<Rigidbody> ();
		lugarInicio = transform.position;
		QuaInucio = transform.rotation;
	}



	void Update ()
		{
		if (disparado== true) 
		{
			contador += Time.deltaTime;
			print ("ooooo");

		}
			

		if (contador >= subir) 
			{
				rb.velocity = Vector3.zero;
				rb.angularVelocity = Vector3.zero;

				rb.MovePosition (lugarInicio);
				rb.MoveRotation (QuaInucio);

				contador = 0;
			disparado = false;


				print ("puo");

			}

	
		}
}
