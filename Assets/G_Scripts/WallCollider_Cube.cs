﻿using UnityEngine;
using System.Collections;

public class WallCollider_Cube : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bullet")
        {
            Destroy(other.gameObject);//移除子彈
            Debug.Log("被子彈打到 : "+gameObject.name);
        }
    }
}
