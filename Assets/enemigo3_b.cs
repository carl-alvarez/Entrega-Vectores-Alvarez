
using System.Collections;
using UnityEngine;

public class enemigo3_b : MonoBehaviour
{
    public float maxDist = 2f;
    public Transform posJugador;
    public float speed = 1f;
    

    private enum EnemyType
    {
        lookAtP1,
        followP1

    }
    [SerializeField] private EnemyType enemyType;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switcheru(enemyType);
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

    void switcheru(EnemyType enemyType)
    {
        switch (enemyType)
        {
            case EnemyType.lookAtP1:
                LookAtPl();
                break;

            case EnemyType.followP1:
                checkDist();
                FollowP1();
                break;
            default:
                break;

        }
    }

}
