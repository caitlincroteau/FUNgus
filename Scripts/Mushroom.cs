using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : MonoBehaviour
{
    public float MushroomSpeed = 8f;
    public bool goingRight = true;
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    
    {
        if(goingRight) {
            //sprite image is default green mushroom
            transform.position += Vector3.right * MushroomSpeed * Time.deltaTime;
        } else {
            transform.position += Vector3.left * MushroomSpeed * Time.deltaTime;
            //changes sprite image to red mushroom
            ChangeSprite();
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "PedroPascal") {
            // Destroy(other.gameObject);
            other.gameObject.transform.Rotate(0,0,-90);
        } 
    }

    void ChangeSprite() {
        spriteRenderer.sprite = newSprite;
    }
}
