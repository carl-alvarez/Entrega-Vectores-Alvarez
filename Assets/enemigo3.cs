
using UnityEngine;

public class enemigo3 : MonoBehaviour
{
    public float maxDist = 2f;
    public Transform posJugador;
    public float speed = 1f;
    public int behave = 1;
    

    
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        switch (behave)
        {
            case 1:
                LookAtPl();
                FollowP1();
                checkDist();
                break;
            case 2:
                LookAtPl();
                break;
            default:
                break;

        }
        
    }

    void LookAtPl()
    {
        Quaternion lookOnLook = Quaternion.LookRotation(posJugador.position - transform.position);

        transform.rotation = Quaternion.Slerp(transform.rotation, lookOnLook, Time.deltaTime);
    }
    void FollowP1()
    {
        transform.position = Vector3.MoveTowards(transform.position, posJugador.position, speed * Time.deltaTime);
        //transform.position = Vector3.MoveTowards(transform.position , posJugador.position, Time.deltaTime);
    }

    void checkDist()
    {
        float dist = Vector3.Distance(posJugador.position, transform.position);

        if (dist < maxDist)
        {
            speed = 0;
        }
        else
        {
            speed = 1f;
        }

    }
}
