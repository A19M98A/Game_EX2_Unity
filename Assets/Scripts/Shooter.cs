﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Fire1"))
        {
            Debug.Log("ay baba");
        }
    }
}
