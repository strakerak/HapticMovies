using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Bhaptics.SDK2;
using System.Threading;

public class Jbhapticsplay1 : MonoBehaviour
{
    // Start is called before the first frame update

    public float waitTime;
    void Start()
    {
        StartCoroutine(delayer());
        BhapticsLibrary.Play("jaws");   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator delayer()
    {
        yield return new WaitForSeconds(waitTime);
    }
}
