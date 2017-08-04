using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBehaviour : MonoBehaviour
{
    public Transform lookAtTarget;
    public float volume=0.5f;

    public int propriedade;
    public string texto;

    public List<int> list= new List<int>() { 1,2,3,4,5 };

    public void DoSomething()
    {
        Debug.Log("KOEH");
        transform.localPosition = Vector3.zero;
        transform.LookAt(lookAtTarget);
    }
}
