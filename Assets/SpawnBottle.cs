﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBottle : MonoBehaviour
{
	public GameObject bottle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void onTouch()
	{
		Instantiate(bottle, new Vector3(0, 0, 0), Quaternion.identity);
	}
}
