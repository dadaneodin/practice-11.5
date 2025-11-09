using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Corutine : MonoBehaviour
{
    private void Start()
    {
        Coroutine coroutine = StartCoroutine(Timer());
        StopCoroutine(coroutine);
    }
    private IEnumerator Timer()
    {
        for (int i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(1);
            Debug.Log(i);
        }
    }
}
