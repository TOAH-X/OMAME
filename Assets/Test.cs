using UnityEngine;

public class Test : MonoBehaviour
{
    void Update()
    {
        EndGame();
    }

    //Q[IΉ
    private void EndGame()
    {
        //Escͺ³κ½
        if (Input.GetKey(KeyCode.Escape))
        {

#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;//Q[vCIΉ
#else
            Application.Quit();//Q[vCIΉ
#endif
        }

    }
}