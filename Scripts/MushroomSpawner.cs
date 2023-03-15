using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomSpawner : MonoBehaviour
{
    [SerializeField] private GameObject mushroom;
    private float timer;
    public bool sendRight = true;

    public float MaxY = 7.0f;
    public float MinY = -7.0f;
    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(1.0f, 3.0f);
        Instantiate(mushroom, transform.position, transform.rotation);
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        
        if(timer <= 0.0f){
            //reset timer
            timer = Random.Range(1.0f, 3.0f);
        
            //set new y position for spawner
            float yPos = Random.Range(MinY,MaxY);
            transform.position = new Vector3 (transform.position.x, yPos, transform.position.z);
            
            //spawn mushroom and set its direction
            GameObject newM = Instantiate(mushroom, transform.position, transform.rotation);
            newM.GetComponent<Mushroom>().goingRight = sendRight;
        }
    }
}
