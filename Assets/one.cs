using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class one : MonoBehaviour
{
    private JointMotor root;
    [SerializeField]private bool mover;


    void Start()
    {
        root = GetComponent<HingeJoint>().motor;
    }
    void Update()
    {
        Debug.Log(transform.eulerAngles.z);
        if (Math.Floor(transform.eulerAngles.z) ==  30)
        {
            Debug.Log(transform.eulerAngles.z);
            root.targetVelocity *= -1;
            GetComponent<HingeJoint>().motor = root;

        }else if(Math.Floor(transform.eulerAngles.z) == 330 ){
            root.targetVelocity *= -1;
            GetComponent<HingeJoint>().motor = root;

        }
    }
}
