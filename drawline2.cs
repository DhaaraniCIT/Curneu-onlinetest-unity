using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawline2 : MonoBehaviour
{
    // Start is called before the first frame update
    private LineRenderer lineRender;
    private float counter;
    private float dist;

    private LineRenderer lineRender1;
    private float counter1;
    private float dist1;

    public Transform origin;
    public Transform destination;

    public Transform origin1;
    public Transform destination1;

    public float linedrawspeed = 6f;
    public float startwidth = 0.45F;
    public float endwidth = 0.45F;

    void Start()
    {
        lineRender = GetComponent<LineRenderer>();
        lineRender.SetPosition(0, origin.position);
        lineRender.SetWidth(startwidth, endwidth);
        dist = Vector3.Distance(origin.position, destination.position);

        lineRender1 = GetComponent<LineRenderer>();
        lineRender1.SetPosition(0, origin1.position);
        lineRender1.SetWidth(startwidth, endwidth);
        dist1 = Vector3.Distance(origin1.position, destination1.position);
    }

    // Update is called once per frame
    void Update()
    {
            if (counter < dist)
            {
                counter += .1f / linedrawspeed;
                float x = Mathf.Lerp(0, dist, counter);
                Vector3 pointA = origin.position;
                Vector3 pointB = destination.position;

                Vector3 pointAlongLine = x * Vector3.Normalize(pointB - pointA) + pointA;
                lineRender.SetPosition(1, pointAlongLine);
            }

        if (counter1 < dist1)
        {
            counter1 += .1f / linedrawspeed;
            float x = Mathf.Lerp(0, dist1, counter1);
            Vector3 pointA = origin1.position;
            Vector3 pointB = destination1.position;

            Vector3 pointAlongLine = x * Vector3.Normalize(pointB - pointA) + pointA;
            lineRender1.SetPosition(1, pointAlongLine);
        }

    }
}
