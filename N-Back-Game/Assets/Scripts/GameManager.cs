using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // var
    int score = 0;
    int btnNum;
    int[] rand=new int[10];
    int i,n=0;
    bool isPause;
    public GameObject O,X,InvisibleBtn,ReadyPanel;
    void Start()
    {
        int r = Random.Range(0, 10);
        
    }
    //난수 초기화 함수
    public void NBackNum()
    {
        for (n = 2; n < 5; n++)
        {
            ReadyPanel.SetActive(false);
            for (i = 0; i < 10; i++)
            {
                //화면에 숫자 출력
                rand[i] = r;
                if (i > n - 1)
                {
                    InvisibleBtn.SetActive(false);
                    if (btnNum == rand[i - n])
                    {
                        O.SetActive(true);

                        O.SetActive(false);
                    }
                }



            }
        }
    }
    public void Zero()
    {
        btnNum = 0;
        Debug.Log("0");
    }
    public void One()
    {
        btnNum = 1;
        Debug.Log("1");
    }
    public void Two()
    {
        btnNum = 2;
        Debug.Log("2");
    }
    public void Three()
    {
        btnNum = 3;
        Debug.Log("3");
    }
    public void Four()
    {
        btnNum = 4;
        Debug.Log("4");
    }
    public void Five()
    {
        btnNum = 5;
        Debug.Log("5");
    }
    public void Six()
    {
        btnNum = 6;
        Debug.Log("6");
    }
    public void Seven()
    {
        btnNum = 7;
        Debug.Log("7");
    }
    public void Eight()
    {
        btnNum = 8;
        Debug.Log("8");
    }
    public void Nine()
    {
        btnNum = 9;
        Debug.Log("9");
    }
}
