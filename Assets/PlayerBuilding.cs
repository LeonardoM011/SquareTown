using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBuilding : MonoBehaviour {

    public Vector3 spawnPosition;
    public Transform prefab;

    float gridWidth;

    // Start is called before the first frame update
    void Start() {
        gridWidth = GameObject.Find("Constants").GetComponent<Constants>().gridWidth;
    }

    // Update is called once per frame
    void Update() {
        if(Input.GetButtonDown("Fire1")) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.Log("" + ray);
            float x_pos = (float)Math.Round(ray.origin.x * gridWidth) / gridWidth;
            float y_pos = (float)Math.Round(ray.origin.y * gridWidth) / gridWidth;
            Instantiate(prefab, new Vector3(x_pos, y_pos, 0.0f), Quaternion.identity);
            /*if(Physics.Raycast(ray)) {
                Instantiate(spawnObject, spawnPosition, spawnRotation);
                //Instantiate(spawnObject);
            }*/
        }
    }
}
