using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Right : MonoBehaviour
{
    //���x
    public float speed = 5f;
    //��]���x
    public float rotationSpeed = 100f;
    //�����z�u
    private Vector3 teleportPosition = new Vector3(0.5f, 0f, 0f);
    //����
    private Quaternion initialRotation;

    // Start is called before the first frame update
    void Start()
    {
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

        //�����ړ�
        if (Input.GetKey(KeyCode.L))
        {
            Vector3 movement = new Vector3(speed * Time.deltaTime, 0f, 0f);
            transform.position += movement;
        }
        if (Input.GetKey(KeyCode.J))
        {
            Vector3 movement = new Vector3(-speed * Time.deltaTime, 0f, 0f);
            transform.position += movement;
        }
        if (Input.GetKey(KeyCode.I))
        {
            Vector3 movement = new Vector3(0f, 0f, speed * Time.deltaTime);
            transform.position += movement;
        }
        if (Input.GetKey(KeyCode.K))
        {
            Vector3 movement = new Vector3(0f, 0f, -speed * Time.deltaTime);
            transform.position += movement;
        }
        //�����ړ�
        if (Input.GetKey(KeyCode.U))
        {
            Vector3 movement = new Vector3(0f, speed * Time.deltaTime, 0f);
            transform.position += movement;
        }
        if (Input.GetKey(KeyCode.O))
        {
            Vector3 movement = new Vector3(0f, -speed * Time.deltaTime, 0f);
            transform.position += movement;
        }
        //����]
        if (Input.GetKey(KeyCode.N))
        {
            float rotationAmount = rotationSpeed * Time.deltaTime;
            transform.Rotate(new Vector3(0f, 0f, rotationAmount));
        }
        //�E��]
        if (Input.GetKey(KeyCode.M))
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
