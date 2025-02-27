using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public int health = 100;
    public float speed = 4.5f;
    public string hero = "Peter";
    public bool isAlive = true;

    public Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("My name is" + hero);


    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * Time.deltaTime * speed);
            //the dot is thre to access a functionality of transform


    }

    private void OnMove(InputValue value)
    {
        Vector2 inputValue = value.Get<Vector2>();
        direction = new Vector3(
            inputValue.x,
            0,
            inputValue.y
            );
        //asks the inoput system what keys are being pressed

            Debug.Log("My name is" + hero);

    }
}
