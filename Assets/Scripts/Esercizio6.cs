using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio6 : MonoBehaviour
{
    public int[] num = new int[20];
    // Start is called before the first frame update
    void Start()
    {
        num = GeneraArray();
        Debug.Log(SommaArray(num));
        StampaArray(num);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int[] GeneraArray()
    {
        int[] arr = new int[20];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Random.Range(0,100) + 1;
            
        }
        return arr;
    }
    int SommaArray(int[]num)
    {
        int num2 =0;
        for (int i = 0; i < num.Length;i++)
        {
            num2 += num[i];
        }
        return num2;
    }
    void StampaArray(int[] print)
    {
        for (int i = 0; i < print.Length; i++)
        {
            Debug.Log(print[i]);
        }
    }

}
