using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class OrbitScript : MonoBehaviour
{
    public Transform orbitCenter;

    private LineRenderer path;
    public float timeMultiplier = 1;
    public float timeOffset = 0;
    public int res = 32;

    public float radius = 10;
    public float time = 0;
    public int timeFlip = 1;

    void Start()
    {

        path = GetComponent<LineRenderer>();
        UpdateOrbitPath();
    }

    void Update()
    {
        if (!orbitCenter) return;
        time = time + Time.deltaTime * timeFlip;
        float x = radius * Mathf.Cos(time * timeMultiplier + timeOffset);
        float z = radius * Mathf.Sin(time * timeMultiplier + timeOffset);

        transform.position = new Vector3(x, 0, z) + orbitCenter.position;

        if (orbitCenter.hasChanged) UpdateOrbitPath();
    }
    void UpdateOrbitPath()
    {
        if (!orbitCenter) return;



        Vector3[] pts = new Vector3[res];

        for (int i = 0; i < pts.Length; i++)
        {
            float x = radius * Mathf.Cos(i * 2 * Mathf.PI / res);
            float z = radius * Mathf.Sin(i * 2 * Mathf.PI / res);

            Vector3 pt = new Vector3(x, 0, z) + orbitCenter.position;
            pts[i] = pt;
        }

        path.positionCount = res;
        path.SetPositions(pts);


    }


}
