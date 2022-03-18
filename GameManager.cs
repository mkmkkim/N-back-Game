using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // var
    static GameManager instance = null;
    private float Timer;
    int btnNum;
    public int randomInt;
    int[] rand = new int[19];
    int[] tmp = {0,1,2,3,4,5,6,7,8,9};
    int i = 0;  //횟수 체크
    int rnd=1;  //라운드
    int n = 2;  //n back에서 n
    public int scoreValue=0;    //맞춘 개수
    /*bool isPause;*/
    
    public GameObject O, X, InvisibleBtn, ReadyPanel;
    public Text numText;
    public Text Round;
    public Text Nback;
    public static GameManager Instance//실제 접근
    {
        get
        {
            if (null == instance)
            {
                return null;
            }
            return instance;
        }
    }
    void Start()
    {
        if (null == instance)
        {
            instance = this;
        }
        numText = GetComponent<Text>();
        Round = GetComponent<Text>();
        Nback = GetComponent<Text>();
    }
    void Update()
    {
        Timer += Time.deltaTime;
        if (Timer <= 3.0f)
        {
            Timer++;
            if (Timer==1.0f)
            {
                ReadyPanel.SetActive(true);
                Round.text = "Round " + rnd;
                Nback.text = n + " Back";
            }
            if (Timer==2.5f)
            {
                Round.GetComponent<Animation>().Play("round");
                Nback.GetComponent<Animation>().Play("nback");
            }
            if (Timer == 2.7f)
            {
                ReadyPanel.SetActive(false);
            }
        }
        if (Timer > 3.0f) { 
            InvokeRepeating("NBackNum", 3.0f, 3.0f);
            randomInt = Random.Range(0, 10);
        }
    }
    //난수 초기화 함수
    public void NBackNum()
    {
        rand[i] = randomInt;
        Debug.Log(rand[i]);
        numText.text = tmp[randomInt].ToString();
        if (i > n - 1)
        {
            InvisibleBtn.SetActive(false);
            if (btnNum == rand[i - n])
            {
                O.SetActive(true);
                Invoke("Term", 1.0f);
                scoreValue++;
                O.SetActive(false);
            }
            else
            {
                X.SetActive(true);
                Invoke("Term", 1.0f);
                X.SetActive(false);
            }
        }
        else if (i > 19)
        {
            EndingScene();
        }
        i++;
    }
    public void Term()
    {
        Debug.Log("latency");
    }
    private void CancleInvoke()
    {
        CancelInvoke("NBackNum");
    }
    public void Zero()
    {
        btnNum = 0;
        Debug.Log("00");
    }
    public void One()
    {
        btnNum = 1;
        Debug.Log("01");
    }
    public void Two()
    {
        btnNum = 2;
        Debug.Log("02");
    }
    public void Three()
    {
        btnNum = 3;
        Debug.Log("03");
    }
    public void Four()
    {
        btnNum = 4;
        Debug.Log("04");
    }
    public void Five()
    {
        btnNum = 5;
        Debug.Log("05");
    }
    public void Six()
    {
        btnNum = 6;
        Debug.Log("06");
    }
    public void Seven()
    {
        btnNum = 7;
        Debug.Log("07");
    }
    public void Eight()
    {
        btnNum = 8;
        Debug.Log("08");
    }
    public void Nine()
    {
        btnNum = 9;
        Debug.Log("09");
    }
    public void EndingScene()
    {
        SceneManager.LoadScene("EndingScene");
    }
}
