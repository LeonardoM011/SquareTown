using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBuilding : MonoBehaviour {

    public Vector3 spawnPosition;
    public Transform prefab;
    
    

    float gridWidth = 2.0f;

    void Start() {
        
    }

    void Update() {
        if(Input.GetButtonDown("Fire1")) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float x_pos = (float)Math.Round(ray.origin.x * gridWidth) / gridWidth;
            float y_pos = (float)Math.Round(ray.origin.y * gridWidth) / gridWidth;
            Instantiate(prefab, new Vector3(x_pos, y_pos, 0.0f), Quaternion.identity);
        }
    }
}
