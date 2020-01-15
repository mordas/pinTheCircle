﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedleMovement : MonoBehaviour
{
[SerializeField]
private GameObject _needleBody;
private bool _canFireNeedle;
private bool _touchedTheCircle;
private float _foceY = 70f;
private Rigidbody2D _myBody;


void Awake(){
Initialize();
}
void Update() {
if(_canFireNeedle) 
   _myBody.velocity = new Vector2(0, _foceY);
}

public void FireTheNeedle(){
_needleBody.SetActive(true);
_myBody.isKinematic = false;
_canFireNeedle = true;
}

void Initialize(){
    _needleBody.SetActive(false);
    _myBody = GetComponent<Rigidbody2D>();
    _myBody.isKinematic = true;
}
}