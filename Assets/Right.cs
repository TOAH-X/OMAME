using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Right : MonoBehaviour
{
    //速度
    public float speed = 5f;
    //回転速度
    public float rotationSpeed = 100f;
    //初期配置
    private Vector3 teleportPosition = new Vector3(0.5f, 0f, 0f);
    //向き
    private Quaternion initialRotation;

    // Start is called before the first frame update
    void Start()
    {
        //初期の向き
        initialRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        //低速
        if (Input.GetKey(KeyCode.LeftShift))
        {
            //速度
            speed = 2.5f;
            //回転速度
            rotationSpeed = 50f;
        }
        else
        {
            //速度
            speed = 5f;
            //回転速度
            rotationSpeed = 100f;
        }

        //水平移動
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
        //鉛直移動
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
        //左回転
        if (Input.GetKey(KeyCode.N))
        {
            float rotationAmount = rotationSpeed * Time.deltaTime;
            transform.Rotate(new Vector3(0f, 0f, rotationAmount));
        }
        //右回転
        if (Input.GetKey(KeyCode.M))
        {
            float rotationAmount = rotationSpeed * Time.deltaTime;
            transform.Rotate(new Vector3(0f, 0f, -rotationAmount));
        }
        //初期配置
        if (Input.GetKey(KeyCode.R))
        {
            transform.position = teleportPosition;
            transform.rotation = initialRotation;
        }
    }
}
