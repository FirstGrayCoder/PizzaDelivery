using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    public Rigidbody rb;
    private PlayerMoving playerMove;
    public float speed;
    [SerializeField] RectTransform joyHandle;
    public Joystick joystick;
    private float moveInput;
    [SerializeField] private GameObject losePanel;


    void Start()
    {
        losePanel.SetActive(false);
        rb = GetComponent<Rigidbody>();
        playerMove = GetComponent<PlayerMoving>();
    }

    void FixedUpdate()
    {
        moveInput = joystick.Horizontal;
        if (moveInput > 0 && speed <= 15)
        {
            speed += 0.25f;
        }
        else if (moveInput < 0 && speed != 0)
        {
            speed -= 0.25f;

        }
        else if (moveInput == 0) speed = 1;
        if (speed == 0) speed = 1;
        playerMove.transform.Translate(speed * Time.deltaTime * Vector3.forward);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            losePanel.SetActive(true);
            Time.timeScale = 0;

        }
    }
}
