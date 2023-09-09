using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Left : MonoBehaviour
{
    //���x
    public float speed = 5f;
    //��]���x
    public float rotationSpeed = 100f;
    //�����z�u
    private Vector3 teleportPosition = new Vector3(-0.5f, 0f, 0f);
    //����
    private Quaternion initialRotation;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        //�����̌���
        initialRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
        //�ᑬ
        if (Input.GetKey(KeyCode.LeftShift))
        {
            //���x
            speed = 2.5f;
            //��]���x
            rotationSpeed = 50f;
        }
        else
        {
            //���x
            speed = 5f;
            //��]���x
            rotationSpeed = 100f;
        }

        /*

        //�����ړ�
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector3(0, 10.0f, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector3(-speed * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 movement = new Vector3(0f, 0f, speed * Time.deltaTime);
            transform.position += movement;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 movement = new Vector3(0f, 0f, -speed * Time.deltaTime);
            transform.position += movement;
        }
        //�����ړ�
        if (Input.GetKey(KeyCode.Q))
        {
            Vector3 movement = new Vector3(0f, speed * Time.deltaTime, 0f);
            transform.position += movement;
        }
        if (Input.GetKey(KeyCode.E))
        {
            Vector3 movement = new Vector3(0f, -speed * Time.deltaTime, 0f);
            transform.position += movement;
        }
        //����]
        if (Input.GetKey(KeyCode.C))
        {
            float rotationAmount = rotationSpeed * Time.deltaTime;
            transform.Rotate(new Vector3(0f, 0f, rotationAmount));
        }
        //�E��]
        if (Input.GetKey(KeyCode.V))
        {
            float rotationAmount = rotationSpeed * Time.deltaTime;
            transform.Rotate(new Vector3(0f, 0f, -rotationAmount));
        }
        //�����z�u
        if (Input.GetKey(KeyCode.R))
        {
            transform.position = teleportPosition;
            transform.rotation = initialRotation;
        }
        */
        
        //�����ړ�
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 movement = new Vector3(speed * Time.deltaTime, 0f, 0f);
            transform.position += movement;
            //rb.position += movement;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 movement = new Vector3(-speed * Time.deltaTime, 0f, 0f);
            transform.position += movement;
            //rb.position += movement;
        }
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 movement = new Vector3(0f, 0f, speed * Time.deltaTime);
            transform.position += movement;
            //rb.position += movement;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 movement = new Vector3(0f, 0f, -speed * Time.deltaTime);
            transform.position += movement;
            //rb.position += movement;
        }
        //�����ړ�
        if (Input.GetKey(KeyCode.Q))
        {
            Vector3 movement = new Vector3(0f, speed * Time.deltaTime, 0f);
            transform.position += movement;
        }
        if (Input.GetKey(KeyCode.E))
        {
            Vector3 movement = new Vector3(0f, -speed * Time.deltaTime, 0f);
            transform.position += movement;
        }
        //����]
        if (Input.GetKey(KeyCode.C))
        {
            float rotationAmount = rotationSpeed * Time.deltaTime;
            transform.Rotate(new Vector3(0f, 0f, rotationAmount));
        }
        //�E��]
        if (Input.GetKey(KeyCode.V))
        {
            float rotationAmount = rotationSpeed * Time.deltaTime;
            transform.Rotate(new Vector3(0f, 0f, -rotationAmount));
        }
        //�����z�u
        if (Input.GetKey(KeyCode.R))
        {
            transform.position = teleportPosition;
            transform.rotation = initialRotation;
        }
        

    }
}