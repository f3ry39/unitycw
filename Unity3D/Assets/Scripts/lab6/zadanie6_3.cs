using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadanie6_3 : MonoBehaviour
{
    public Transform navigationStartPoint;
    public Transform navigationEndPoint;

    private Vector3 startPoint;
    private Vector3 endPoint;
    public float speed;

    private Vector3 currentPlatformPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPoint = navigationStartPoint.position;
        endPoint = navigationEndPoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        currentPlatformPosition = Vector3.Lerp(startPoint, endPoint, Mathf.PingPong(Time.time * speed, 1));
        transform.position = currentPlatformPosition;
    }
}
