using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreacionObjetos : MonoBehaviour
{

    [SerializeField]
    GameObject prefabfreezer;
    GameObject objetoCreado;
    void Start()
    {
        
    }

    
    void Update()
    {

        /*if (Input.GetMouseButtonDown(0))
        {
            objetoCreado = Instantiate(prefabfreezer, Vector3.zero, Quaternion.identity);
            objetoCreado.SetActive(true);
        }



        //objetoCreado.SetActive(false);

        if (prefabfreezer.activeSelf)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                objetoCreado.transform.position = hit.point;

            }
        }

        objetoCreado.SetActive(true);*/

       

    }

    /*public void Creacion1()
    {

        if (Input.GetMouseButtonDown(0))
        {
            objetoCreado = Instantiate(prefabfreezer, Vector3.zero, Quaternion.identity);
            objetoCreado.SetActive(true);
        }

        if (prefabfreezer.activeSelf)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                objetoCreado.transform.position = hit.point;

            }
        }
    }*/
  
}
