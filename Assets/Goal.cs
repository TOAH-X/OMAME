using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    //経過時間
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
        //豆召喚
        GameObject mameObject = Instantiate(mamePrefab, new Vector3(-10f, 3f, 0f), Quaternion.identity);
        mameObject.name = "Mame";
        Clear = false;
        bubudukeCounter = 0;
        elapsedTime = 0f;

        //効果音のComponentを取得
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //時間計測
        if (timerStop == false)
        {
            elapsedTime += Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.R) && Clear == false) 
        {
            //旧豆廃棄
            GameObject[] mameObjectsMame = GameObject.FindGameObjectsWithTag("Mame");
            foreach (GameObject mameObjectMame in mameObjectsMame)
            {
                Destroy(mameObjectMame);
            }
            //豆再召喚
            GameObject mameObject = Instantiate(mamePrefab, new Vector3(-10f, 3f, 0f), Quaternion.identity);
            mameObject.name = "Mame";
            //時間リセット
            elapsedTime = 0f;
            //ぶぶ漬けカウンター
            bubudukeCounter++;
        }
        //煽りコメ
        if (bubudukeCounter >= 10 && bubudukeCounter % 10 == 0) 
        {
            ShowImage();
        }
        //煽りコメオフ
        if (bubudukeCounter >= 10 && bubudukeCounter % 10 == 1)
        {
            HideImage();
        }
        //タイトル帰還
        if (Clear==true)
        {
            //クリア画像
            claearImage.gameObject.SetActive(true);
            //クリアボタン
            buttonToActivate.gameObject.SetActive(true);
        }
    }

    //接触判定(クリア)
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Mame") 
        {
            timerStop = true;
            GetComponent<Renderer>().material.color = Color.yellow;

            if (Clear == false)
            {
                //クリアSE
                audioSource.PlayOneShot(sound1);
            }
            Clear = true;


        }
    }

    //ぶぶ漬け表示
    private void ShowImage()
    {
        imageToShow.gameObject.SetActive(true);
    }
    //ぶぶ漬け廃棄
    private void HideImage()
    {
        imageToShow.gameObject.SetActive(false);
    }

}
