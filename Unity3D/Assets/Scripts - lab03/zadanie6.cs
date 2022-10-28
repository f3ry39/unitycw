using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadanie6 : MonoBehaviour
{
    // Smooth towards the height of the target

    Transform target;
    float smoothTime = 0.3f;
    float yVelocity = 0.0f;
    public GameObject Target;

    void Start()
    {

    }

    void Update()
    {
        float newPosition = Mathf.SmoothDamp(transform.position.y, target.position.y, ref yVelocity, smoothTime);
        transform.position = new Vector3(transform.position.x, newPosition, transform.position.z);
    }
}