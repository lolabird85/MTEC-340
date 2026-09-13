using System.Net.Mail;
using Unity.Mathematics;
using Unity.Mathematics.Geometry;
using UnityEngine;

public class ControlFlow : MonoBehaviour
{
    public bool flag = true;
    public int startingPower = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
       
        if(flag)
        {
            Debug.Log("Boolean flag is set");
        }
        else
        {
            Debug.Log("Boolean flag is not set");
        }
        for (int i = 0; i < 10; i++)
        {
            Debug.Log("The " + startingPower + " power of 2 is " + math.pow(2, startingPower));
            startingPower++;
        }
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
