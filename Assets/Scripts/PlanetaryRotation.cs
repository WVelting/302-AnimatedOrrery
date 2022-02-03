using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetaryRotation : MonoBehaviour
{
    private Quaternion axis = new Quaternion();
    public float speed;
    public float rot = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        //axis = Quaternion.Euler(tilt);
        //transform.rotation = axis;
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.rotation = axis;
        rot += Time.deltaTime * speed;
        transform.localRotation = Quaternion.Euler(0,rot,0);
        
    }
}
