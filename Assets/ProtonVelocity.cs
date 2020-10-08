using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtonVelocity : MonoBehaviour
{
    public float Vx;
    public float Vy;
    Rigidbody proton;

    // Start is called before the first frame update
    void Start()
    {
        proton = GetComponent<Rigidbody>();
        proton.velocity = new Vector3(Vx,Vy,0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
