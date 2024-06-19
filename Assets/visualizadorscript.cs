using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visualizadorscript : MonoBehaviour
    
{
    public GameObject[] alimento;
    public int alimentovisualizado;
    // Start is called before the first frame update
    void Start()
    {
        deactivateAll();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            deactivateAll();
            SiguienteObjeto();

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            deactivateAll();
            AnteriorObjeto();
        }

    }

    void SiguienteObjeto()
    {
        alimentovisualizado++;
        alimento[alimentovisualizado].SetActive(true);
        if (alimentovisualizado >= alimento.Length)
        {
            alimentovisualizado = alimento.Length - 1;
        }

    }

    void AnteriorObjeto()
    {
        alimentovisualizado--;
        alimento[alimentovisualizado].SetActive(true);
        if (alimentovisualizado<0)
        {

            alimentovisualizado = 0;
        }
    }
    void deactivateAll()
    {
        for(int i = 0; i < alimento.Length; i++)
        {
            alimento[i].SetActive(false);
        }
    }
}
