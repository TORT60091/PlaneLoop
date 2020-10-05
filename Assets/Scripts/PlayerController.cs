using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float selfRotationSpeed;
    float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (GameManager.instance.isGameOver)
        {
            return;
        }
    }

    public void GameOver()
    {
        Debug.Log("GAME OVER");

        GameManager.instance.GameOver();
        selfRotationSpeed = 0;
        speed = 0;

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Jump");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);
        transform.Rotate(Vector3.right * selfRotationSpeed * Time.deltaTime);
    }


}
