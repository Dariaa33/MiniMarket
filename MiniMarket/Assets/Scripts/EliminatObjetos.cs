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
    
    void Start()
    {
        isMoving = false;
    }

    
    void Update()
    {
       // для срабатывания выбора объекта
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


            if (Physics.Raycast(ray, out hit, raycastDistance) && hit.collider.GetComponent<Item>())
            {

                selectedObject = hit.collider.gameObject;

                // выводит в консоль выбранный объект
                Debug.Log("Seleccionaste el objeto: " + selectedObject.name);

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
}