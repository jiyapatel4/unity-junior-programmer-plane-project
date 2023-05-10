using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanePropeller : MonoBehaviour
{
    // propeller speed var
    private float speed = 1000;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }
}
