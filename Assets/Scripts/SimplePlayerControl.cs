using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlayerControl : MonoBehaviour
{
    // Start of defining variables
    private float x;
    private float y;
    public Rigidbody2D rb2D;

    [SerializeField]
    public float Speed;

    [SerializeField]
    public float SmoothStopParam;

    [SerializeField]
    public float JumpHeight;

    // Start is called before the first frame update
    void Start()
    {
        
        // If the user of this sets the SmoothStopParam float to a value higher than 1
        if (SmoothStopParam >= 1)
            SmoothStopParam = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        // Make it so the variables go to zero eventually
        x = (x * SmoothStopParam);
        y = (y * 0.1f); 
        Application.targetFrameRate = 60; // Framelimit cause my code is bad

        // Controller inputs
        if (Input.GetButton("Left"))
            x = Speed * -1.0f;
        else if (Input.GetButton("Right"))
            x = Speed;
        if (Input.GetButtonDown("Up")) // I'm too lazy to make it so this gets disabled if you are airborne
            rb2D.AddForce(transform.up * JumpHeight, ForceMode2D.Impulse);

        // Control Position of gameObject
        gameObject.transform.position = new Vector2 (transform.position.x + x, transform.position.y + y);
    }
}
