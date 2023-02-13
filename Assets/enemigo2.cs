using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class enemigo2 : MonoBehaviour
{
    public float maxDist = 2f;
    public Transform posJugador;
    public float speed = 1f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LookAtPl();
    }

    
    void LookAtPl()
    {
        Quaternion lookOnLook = Quaternion.LookRotation(posJugador.position - transform.position);

        transform.rotation = Quaternion.Slerp(transform.rotation, lookOnLook, Time.deltaTime);
    }

    
}
