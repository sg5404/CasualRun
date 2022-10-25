using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoSingleton<GameManager>
{
    public int startNum;
    public int c_num;
    [SerializeField] private TextMeshProUGUI numText;
    void Start()
    {
        c_num = startNum;
        numText.text = c_num.ToString();
    }
   
    void Update()
    {

    }

    public void CurrentNumCheck()
    {
        numText.text = c_num.ToString();
        if (c_num <= 0)
            StopGame();
    }

    void StopGame()
    {
        c_num = 0;
        numText.text = c_num.ToString();
    }
}
