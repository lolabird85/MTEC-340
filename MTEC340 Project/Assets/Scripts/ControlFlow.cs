using System.Net.Mail;
using UnityEngine;

public class ControlFlow : MonoBehaviour
{
    public bool flag = true;

    static int[] _powersOfTwo = new int[10] {2, 4, 8, 16, 32, 64, 128, 256, 512, 1024};
    public int listLength = _powersOfTwo.Length;
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
        for (int i = 0; i < listLength; i++)
        {
            Debug.Log("The " + startingPower + " power of 2 is " + _powersOfTwo[i]);
            startingPower++;
        }
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
