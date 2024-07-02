using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour
{
    [SerializeField]
    Transform CloudSphere;

    [SerializeField]
    float Speed = -20f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CloudSphere.Rotate(Vector3.up, Speed * Time.deltaTime);
    }
}
