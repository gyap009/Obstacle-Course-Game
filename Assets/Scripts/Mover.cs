using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //[SerializeField] float yValue = 0.02f;
    [SerializeField] float moveSpeed = 10f; // can be accessed in the inspector

    // Start is called before the first frame update 
    void Start()
    {
        //transform.Translate(1, 0, 0);
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {   
        MovePlayer();
    }

    void PrintInstructions() {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with WASD or arrow keys");
        Debug.Log("Don't hit the walls!");
    }

    void MovePlayer() {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed; // make it frame rate independent
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, 0 , zValue);
    }
}
