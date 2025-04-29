using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Esercizio3 : MonoBehaviour
{
    // Start is called before the first frame update
    public int Numero;
    
    void Start()
    {
        int i = 1;
        while (i <= 30)
        {
            if  (Numero % 3 == 0 && i % 5 == 0)
            {
                Debug.Log("FizzBuzz");
            }
            else if (Numero % 5 == 0)
            {
                Debug.Log("Buzz");
            }
            else if (Numero % 3 == 0)
            {
                Debug.Log("Fizz");
            }
            else 
            {
                Debug.Log(i);
            }
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
