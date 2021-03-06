﻿using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour
{
    /*
    Appeler ce script :
        CameraShake cameraShake;

    void Start () {
        cameraShake = GameObject.Find("Main Camera").GetComponent<CameraShake>();
        cameraShake.Shaking();
		}
        */


    // Transform of the camera to shake. Grabs the gameObject's transform
    // if null.
    public Transform camTransform;
	
	// How long the object should shake for.
	public float shakeDuration = 0f;
	
	// Amplitude of the shake. A larger value shakes the camera harder.
	public float shakeAmount = 0.1f;
	public float decreaseFactor = 0f;
    public bool shake = false;

	Vector3 originalPos;
	
	void Awake()
	{
		if (camTransform == null)
		{
			camTransform = GetComponent(typeof(Transform)) as Transform;
		}
	}
	
	void OnEnable()
	{
		originalPos = camTransform.localPosition;
	}

	void Update()
	{
		if (shakeDuration > 0 && shake == true)
		{
			camTransform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;
			
			shakeDuration -= Time.deltaTime * decreaseFactor;
		}
		else
		{
			shakeDuration = 0f;
			camTransform.localPosition = originalPos;
		}
	}

    /*void Start()
    {
        //Shaking();
    }*/

    //fonction à appeler pour réinit paramètres de shake
    public void Shaking()
    {
        shake = true;
        shakeDuration = 1;
        decreaseFactor = 1;

        if (shakeDuration < 0)
            shake = false;
    }

    public void Shaking(float duration, float decreaseF)
    {
        shake = true;
        shakeDuration = duration;
        decreaseFactor = decreaseF;

        if (shakeDuration < 0)
            shake = false;
    }
}