using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedroPascal : MonoBehaviour
{
    public float playerSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
    
        
    }

    // Update is called once per frame
    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal"); 
        float deltaY = Input.GetAxis("Vertical");

        Vector3 change = new Vector3(deltaX, deltaY, 0) *playerSpeed* Time.deltaTime;;

        transform.position += change;
        
    }
}
