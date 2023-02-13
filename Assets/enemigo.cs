
using UnityEngine;

public class enemigo : MonoBehaviour
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
        checkDist();
        LookAtPl();
        FollowP1();
    }

    void checkDist()
    {
        float dist = Vector3.Distance(posJugador.position , transform.position);

        if (dist < maxDist)
        {
            speed = 0;
        }else 
        {
            speed = 1f;
        }

    }

    void LookAtPl()
    {
        transform.LookAt(posJugador);
    }

    void FollowP1()
    {
        transform.position = Vector3.MoveTowards(transform.position, posJugador.position, speed * Time.deltaTime);
        //transform.position = Vector3.MoveTowards(transform.position , posJugador.position, Time.deltaTime);
    }
}
