using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APARICIONOBJETOS : MonoBehaviour
{
    public GameObject[] aparicionObjetos;
    public int Numeros = 0;
    // Start is called before the first frame update
    void Start()
    {
        CleanObjetos();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Numeros++;
            if (Numeros >= aparicionObjetos.Length)
            {
                Numeros = 0;
            }
            CleanObjetos();
            visualizarObjeto(Numeros);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Numeros--;
            if (Numeros >= aparicionObjetos.Length)
            {
                Numeros = 0;
            }
            CleanObjetos();
            visualizarObjeto(Numeros);
        }
        if (Numeros < 0)
        {
            Numeros++;
        }
    }
    void CleanObjetos()
    {
        for (int f=0; f < aparicionObjetos.Length; f++)
        {
            aparicionObjetos[f].SetActive(false);
        }
    }
    void visualizarObjeto(int index)
    {
        aparicionObjetos[index].SetActive(true);
    }

}
