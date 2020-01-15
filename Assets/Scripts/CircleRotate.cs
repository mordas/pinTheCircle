using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleRotate : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 50f;
    private bool _canRotate;
    private float _angle;
    void Awake()
    {
       _canRotate = true; 
    }

    // Update is called once per frame
    void Update()
    {
       if(_canRotate) {
RotateCircle();
       }
    }
    void RotateCircle(){
        _angle = transform.rotation.eulerAngles.z;
        _angle +=  Time.deltaTime * _rotationSpeed;
        transform.rotation = Quaternion.Euler(new Vector3(0,0,_angle));
 
    }
}
