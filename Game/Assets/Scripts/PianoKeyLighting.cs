using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoKeyLighting : MonoBehaviour
{

    public Color newColor = Color.red;
    private Color originalColor = Color.blue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

        // Hit Detection
    void OnTriggerEnter2D(Collider2D collision) 
    {
        // when bar hits key light up
        GetComponent<Renderer>().material.color = newColor;
        Debug.Log("Collision");
    } 

    private void OnTriggerExit2D(Collider2D other)
    {
        // Reset the color of the box to its original color
        GetComponent<Renderer>().material.color = originalColor;
        Debug.Log("Collision Over");
    }

}
