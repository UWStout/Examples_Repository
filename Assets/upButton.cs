﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upButton : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject wolf;
    
    void Start()
    {
     wolf = GameObject.Find("Wolf");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Vector2 direction = new Vector3(0, 1, 0);
        wolf.transform.Translate(10 *  direction * Time.deltaTime);
        Debug.Log("Moving Up");
    }
}
