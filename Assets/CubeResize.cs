﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeResize : MonoBehaviour {

    public GameObject cubePrefab;
    public float sizingFactor = 0.02f;
    private GameObject lastSpawn = null;
    private float startSize;
    private float startX;

    // Use this for initialization
    void Start () {
		
	}

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            float positionZ = 10.0f;
            Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, positionZ);
            startX = position.x;
            position = Camera.main.ScreenToWorldPoint(position);
            lastSpawn = Instantiate(cubePrefab, position, transform.rotation) as GameObject;
            startSize = lastSpawn.transform.localScale.z;
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 size = lastSpawn.transform.localScale;
            size.x = startSize + (Input.mousePosition.x - startX) * sizingFactor;
            lastSpawn.transform.localScale = size;
        }
    }
}
