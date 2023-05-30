using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public float health = 100;
    private float maxHealth;
    public float v1;
    public float v2;
    public float v3;

    public GameObject mainCamera;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

    public void takeDamage(float dmg) {
        health -= dmg;

        if (health <= 0) {
            //mainCamera.SetActive(true);
            //Destroy(this.gameObject);
            //Application.LoadLevel(Application.loadedLevel);
            transform.position = new Vector3(v1, v2, v3);
        }
    }
}
