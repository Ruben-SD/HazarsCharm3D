using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class PlayerBlanca : MonoBehaviour
{

	private Animator anim;
	private CharacterController controller;

	public float speed = 4.0f;
	public float turnSpeed = 40.0f;
	private Vector3 moveDirection = Vector3.zero;

	public GameObject[] asteroides;
	private int cercanoAntiguo;
	bool jumping = false;
	public int masCercano = 0;
	bool gravedadactualizada = true;
	private GameObject asteroideActual;
	public Vector3 rotacionAsteroide;




	void Start()
	{
		controller = GetComponent<CharacterController>();
		anim = gameObject.GetComponentInChildren<Animator>();
		asteroides = GameObject.FindGameObjectsWithTag("asteroides");

	}

	void ActualizarGravedad()
	{
		float distanciaCercana = Vector3.Distance(transform.position, asteroides[0].transform.position);
		float distanciaAux;
		cercanoAntiguo = masCercano;
		for (int i = 1; i < asteroides.Length; i++)
		{
			distanciaAux = Vector3.Distance(transform.position, asteroides[i].transform.position);
			if (distanciaAux <= distanciaCercana) { distanciaCercana = distanciaAux; masCercano = i; }
		}

		Physics.gravity = (asteroides[masCercano].transform.position - transform.position) * 10.00f;
		transform.rotation = Quaternion.FromToRotation(transform.up, -Physics.gravity) * transform.rotation;

		if (cercanoAntiguo != masCercano) { gravedadactualizada = true; };
		transform.parent = asteroides[masCercano].transform;
		//gravedadactualizada = true;
	}

	void OnTriggerEnter(Collider other)
	{
		if (gravedadactualizada)
		{
			jumping = false;
			gravedadactualizada = false;
		};
	}

	void OnTrigger(Collider other)
	{
		if (gravedadactualizada)
		{
			jumping = false;
			gravedadactualizada = false;
		};
	}

	void FixedUpdate()
	{
		//if (gravedadactualizada) { asteroideActual = asteroides[masCercano]; };
		//rotacionAsteroide = asteroideActual.gameObject.GetComponent<rotate>().turnVector;
	}


	void Update()
	{

		//if (Input.GetKey("w"))
		//{
		//anim.SetInteger("AnimationPar", 1);
		//}
		//else
		//{
		//anim.SetInteger("AnimationPar", 0);
		//}

		if (controller.isGrounded)
		{
			jumping = false;
			//transform.Translate(new Vector3(-rotacionAsteroide.x * Time.deltaTime, -rotacionAsteroide.y * Time.deltaTime,- rotacionAsteroide.z * Time.deltaTime));
			//transform.Translate(asteroideActual.transform.up* -rotacionAsteroide.z * Time.deltaTime);
			//transform.Translate( new Vector3(-rotacionAsteroide.x * Time.deltaTime*20.00f, -rotacionAsteroide.y * Time.deltaTime * 20.00f, -rotacionAsteroide.z * Time.deltaTime * 20.00f));
		}
		//transform.Translate(asteroideActual.transform.up * -rotacionAsteroide.z * Time.deltaTime);


		ActualizarGravedad();


		anim.SetInteger("AnimationPar", 0);

		//if (Input.GetKey(KeyCode.UpArrow)) { transform.Translate(new Vector3(0, 0, speed * Time.deltaTime)); anim.SetInteger("AnimationPar", 1); };
		if (Input.GetKey("w"))
		{
			transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
			anim.SetInteger("AnimationPar", 1);
		};

		if (Input.GetKey("s"))
		{
			transform.Translate(new Vector3(0, 0, -speed * Time.deltaTime));
			anim.SetInteger("AnimationPar", 1);
		};



		if (Input.GetKey("a"))
		{
			transform.Rotate(0, -turnSpeed * Time.deltaTime, 0);
			//transform.Translate(new Vector3(-rotacionAsteroide.x * Time.deltaTime * 0.10f, -rotacionAsteroide.y * Time.deltaTime * 0.10f, -rotacionAsteroide.z * Time.deltaTime * 0.10f));
		};
		if (Input.GetKey("d"))
		{
			transform.Rotate(0, turnSpeed * Time.deltaTime, 0);
			//transform.Translate(new Vector3(-rotacionAsteroide.x * Time.deltaTime * 0.10f, -rotacionAsteroide.y * Time.deltaTime * 0.10f, -rotacionAsteroide.z * Time.deltaTime * 0.10f));
		};

		if (Input.GetKeyDown(KeyCode.Space) && (!jumping))
		{
			moveDirection = transform.up * 20.00f;
			jumping = true;
		};


		if (jumping == true)
		{
			moveDirection += Physics.gravity * Time.deltaTime;
			controller.Move(moveDirection * Time.deltaTime);
		};


	}
}
