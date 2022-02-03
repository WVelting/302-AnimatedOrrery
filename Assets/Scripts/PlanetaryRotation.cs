using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetaryRotation : MonoBehaviour
{
    private Quaternion axis = new Quaternion();
    public Vector3 tilt = new Vector3(0,0,0);
    public Vector3 rotation = new Vector3(0,0,0);
    
    // Start is called before the first frame update
    void Start()
    {
        axis = Quaternion.Euler(tilt);
        transform.rotation = axis;
        
    }

    // Update is called once per frame
    void Update()
    {
        tilt += rotation;
        axis = Quaternion.Euler(tilt);
        transform.localRotation = axis;
        
    }
}
