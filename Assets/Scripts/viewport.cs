﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class viewport : MonoBehaviour
{
    public Camera cam;
    public Camera cam2;

    void Start()
    {
        cam.rect = new Rect(0, 0, 0.5f, 0.9f);
        cam2.rect = new Rect(0.5f, 0, 0.5f, 0.9f);


        FindObjectOfType<audioManager>().Play("maintheme");

        //  camEclipse.rect = new Rect(0.25f, 0, 0.5f, 0.5f);
    }
}
