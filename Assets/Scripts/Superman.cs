using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Superman : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private Vector3[] points;

    private Vector3 targetPoint;
    private int curentPoint = 0;

    void Start()
    {
        targetPoint = points[curentPoint];
    }

    void Update()
    {
         
     
      //  transform.Rotate(transform.position.x, targetPoint.y, 90);
        // transform.Rotate(0, 90, 0);
        transform.position = Vector3.MoveTowards(transform.position, targetPoint, speed * Time.deltaTime);

        if (transform.position == targetPoint)
        {
            transform.LookAt(targetPoint);
            curentPoint++;
            targetPoint = points[curentPoint];

            if (curentPoint >= points.Length)
            {
                curentPoint = points.Length - 1;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.body.)
        {

        }
    }
}
