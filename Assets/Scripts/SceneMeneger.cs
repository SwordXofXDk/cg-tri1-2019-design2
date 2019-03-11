﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMeneger : MonoBehaviour
{

    [SerializeField]
    private Vector3 TapeSpeed = new Vector3(-2f, 0f, 0);
    [SerializeField]
    private Transform Tape = null;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Tape.position = Tape.position + TapeSpeed * Time.deltaTime;
    }
}