using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planets : MonoBehaviour
{
    [SerializeField]
    float Speed = 20f;

    [SerializeField]
    GameObject ObjectToRotate;

    [SerializeField]
    Transform Sun;

    [SerializeField]
    float OrbitalSpeed = 30f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        ObjectToRotate.transform.Rotate(Vector3.forward, Speed * Time.deltaTime);

        transform.RotateAround(Sun.position, Vector3.up, OrbitalSpeed * Time.deltaTime);
    }
}
