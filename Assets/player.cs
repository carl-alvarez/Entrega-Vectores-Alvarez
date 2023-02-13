
using UnityEditor;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovP1();
    }

    void MovP1()
    {
        float movX = Input.GetAxis("Horizontal");
        float movY = Input.GetAxis("Vertical");
        Vector3 movDir = new Vector3(movX, 0,movY );
        movDir.Normalize();

        transform.Translate(movDir * Time.deltaTime, Space.World);

        if( movDir != Vector3.zero)
        { 
            transform.forward = movDir;
        }
    }
}
