using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public bool podeUsar;
    public string nome;
    public int dano;
}

public class AnotherTestBehaviour : MonoBehaviour
{
    public int vida;
    [Positive]
	public int dano; 
	public string nome;
	public bool morto;
	public bool vivo;
	
	public Item item1;
    public Item item2;
    public Item item3;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
