using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOve : MonoBehaviour
{
    [SerializeField]private float speed;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += new Vector3(transform.position.x * speed * Time.deltaTime, 0);
    }
}
