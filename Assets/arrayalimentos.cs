using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrayalimentos : MonoBehaviour
{
    public GameObject[] Alimentos;
    int random = 0;
    // Start is called before the first frame update
    void Start()
    {
        ResetearAlimentos();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Alimentos[random].SetActive(false);
            random = Random.Range(0, Alimentos.Length);
            Alimentos[random].SetActive(true);
        }
    }
    void ResetearAlimentos()
    {
        //desactivar todos los elementos del array 
        //activar solo el primer elemento
        DesactivarTodoslosElementos();
        Alimentos[0].SetActive(true);
    }

    void DesactivarTodoslosElementos()
    {
        for (int i = 0; i < Alimentos.Length; i++)
        {
            Alimentos[i].SetActive(false);
        }
    }
}


