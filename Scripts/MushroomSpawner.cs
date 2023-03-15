using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomSpawner : MonoBehaviour
{
    [SerializeField] private GameObject mushroom;
    private float timer;
    public bool sendRight = true;

    public float MaxY = 4f;
    public float MinY = -4f;
    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(.5f, 3f);
        Instantiate(mushroom, transform.position, transform.rotation);
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        
        if(timer <= 0f){
            //reset timer
            timer = Random.Range(.5f, 3f);
        
            //set new y position for spawner
            float yPos = Random.Range(MinY,MaxY);
            transform.position = new Vector3 (transform.position.x, yPos, transform.position.z);
            
            //spawn mushroom and set its direction
            GameObject newM = Instantiate(mushroom, transform.position, transform.rotation);
            newM.GetComponent<Mushroom>().goingRight = sendRight;
        }
    }
}
