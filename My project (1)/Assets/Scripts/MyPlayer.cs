using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyPlayer : MonoBehaviour
{

    [SerializeField] private GameObject bullet = null;
    [SerializeField] private Transform bulletStartPosition = null;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var t = Instantiate(bullet, bulletStartPosition.position, transform.rotation).GetComponent<MyBullet>();
            t.Init();
        }       
    }  
    
}
