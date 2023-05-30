using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class KillBox : MonoBehaviour
{
    //private float damage = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider otherObject)
    {

        if (otherObject.transform.tag == "Player")
        {
            Application.LoadLevel(Application.loadedLevel);
            //otherObject.GetComponent<Player>().takeDamage(damage);
        }
    }
}
