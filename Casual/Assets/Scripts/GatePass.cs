using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GatePass : MonoBehaviour
{
    Rigidbody rigid;
    int kind;
    int num;
    string GateText = "";
    [SerializeField] private TextMeshPro tmp;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        kind = Random.Range(0, 4);
        num = Random.Range(0, 9);
        GateSetting();
    }

    void Update()
    {
        
    }

    void GateSetting()
    {
        GateText = kind switch
        {
            0 => "+",
            1 => "-",
            2 => "¡¿",
            3 => "¡À",
            _ => "+",
        };
        GateText += num.ToString();
        tmp.text = GateText;
    }

    public void GateAbility()
    {
        GameManager.Instance.c_num = kind switch
        {
            0 => GameManager.Instance.c_num += num,
            1 => GameManager.Instance.c_num -= num,
            2 => GameManager.Instance.c_num * num,
            3 => GameManager.Instance.c_num / num,
            _ => GameManager.Instance.c_num += num,
        };
    }

    private void OnTriggerEnter(Collider other)
    {
        if(!other.CompareTag("Player"))
            return;
        GateAbility();
        GameManager.Instance.CurrentNumCheck();
    }
}
