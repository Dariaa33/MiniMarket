using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminatObjetos : MonoBehaviour
{
    [SerializeField]
    GameObject ButtonEliminar;
    public float raycastDistance = 100f;
    bool Seleccion = false;
    [SerializeField]
    GameObject selectedObject;
    [SerializeField]
    GameObject buttonRotate;
    bool isMoving;
    [SerializeField]
    GameObject buttonScale;

    void Start()
    {
        isMoving = false;
    }

    
    void Update()
    {
       // para seleccionar los objetos
        if (Input.GetMouseButtonDown(0))
        {

           if (Seleccion = true)
            {

                SelectObject();

            }
            

        }

        if (isMoving == true) 
        {
            selectedObject.SetActive(false);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // команда для того чтобы объект двигался закрепленный за курсором мыши
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                selectedObject.transform.position = hit.point;
            }
            selectedObject.SetActive(true);
            if (Input.GetMouseButtonDown(1))
            {
                 isMoving = false ;
            }
        }

    }

    void SelectObject()
    {


        if (Seleccion ==true)
        {
            // преобразовывает курсор мыши в луч в 3д пространстве игры
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit; 


            if (Physics.Raycast(ray, out hit, raycastDistance) && hit.collider.GetComponent<Item>()) //para que afecta solo a los objetos que tiene este script
            {

                selectedObject = hit.collider.gameObject;

                // pone en console que he seleccionado
                //Debug.Log("Seleccionaste el objeto: " + selectedObject.name);
                
                selectedObject.GetComponent<Renderer>();

            }
        }

    }

    public void BotonEliminar()
    {
        if (ButtonEliminar.activeSelf)
        {
            Destroy(selectedObject);
        }
    }

    public void Rotate()
    {

        if (buttonRotate.activeSelf)
        {

            selectedObject.transform.Rotate(0f, 11f, 0f);
           


        }

    }
    
    public void Mover()
    {
        if(isMoving == true)
        {
            isMoving = false;
            
        }
        if (isMoving == false)
        {
            isMoving = true;
        }
    }

    public void Escalar()
    {
        if(buttonScale.activeSelf)
        {
            /*if()
            {

            }*/
        }
    }
}