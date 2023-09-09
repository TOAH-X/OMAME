using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    //�o�ߎ���
    public static float elapsedTime = 0f;
    bool timerStop = false;

    public GameObject mamePrefab;

    int bubudukeCounter=0;

    public Image imageToShow;

    public Image claearImage;

    public static bool Clear = false;

    public Button buttonToActivate;

    public AudioClip sound1;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        //������
        GameObject mameObject = Instantiate(mamePrefab, new Vector3(-10f, 3f, 0f), Quaternion.identity);
        mameObject.name = "Mame";
        Clear = false;
        bubudukeCounter = 0;
        elapsedTime = 0f;

        //���ʉ���Component���擾
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //���Ԍv��
        if (timerStop == false)
        {
            elapsedTime += Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.R) && Clear == false) 
        {
            //�����p��
            GameObject[] mameObjectsMame = GameObject.FindGameObjectsWithTag("Mame");
            foreach (GameObject mameObjectMame in mameObjectsMame)
            {
                Destroy(mameObjectMame);
            }
            //���ď���
            GameObject mameObject = Instantiate(mamePrefab, new Vector3(-10f, 3f, 0f), Quaternion.identity);
            mameObject.name = "Mame";
            //���ԃ��Z�b�g
            elapsedTime = 0f;
            //�ԂԒЂ��J�E���^�[
            bubudukeCounter++;
        }
        //����R��
        if (bubudukeCounter >= 10 && bubudukeCounter % 10 == 0) 
        {
            ShowImage();
        }
        //����R���I�t
        if (bubudukeCounter >= 10 && bubudukeCounter % 10 == 1)
        {
            HideImage();
        }
        //�^�C�g���A��
        if (Clear==true)
        {
            //�N���A�摜
            claearImage.gameObject.SetActive(true);
            //�N���A�{�^��
            buttonToActivate.gameObject.SetActive(true);
        }
    }

    //�ڐG����(�N���A)
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Mame") 
        {
            timerStop = true;
            GetComponent<Renderer>().material.color = Color.yellow;

            if (Clear == false)
            {
                //�N���ASE
                audioSource.PlayOneShot(sound1);
            }
            Clear = true;


        }
    }

    //�ԂԒЂ��\��
    private void ShowImage()
    {
        imageToShow.gameObject.SetActive(true);
    }
    //�ԂԒЂ��p��
    private void HideImage()
    {
        imageToShow.gameObject.SetActive(false);
    }

}
