using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBullet : MonoBehaviour
{
    private int force = 40;
    public void Init()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * force, ForceMode.Impulse);
    }

    private void OnTriggerEnter(Collider other)
    {        
        if (other.gameObject.isStatic)
        {
            Destroy(gameObject);
        }
    }
}

