using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;�@�@�@//�{�^�����g�p����̂�UI
using UnityEngine.SceneManagement;//SceneManager���g�p����SceneManagement��ǉ�

public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.Return))
        {
            SceneManager.LoadScene("GameScene");
        }
    }

    public void ButtonClick()
    {
        SceneManager.LoadScene("GameScene");
    }
}
