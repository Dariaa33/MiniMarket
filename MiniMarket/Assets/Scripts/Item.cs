using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Item : MonoBehaviour
{
    GameObject objectcr;

    [SerializeField]
    GameObject itemPrefab2;
    [SerializeField]
    GameObject itemPrefab;
    [SerializeField]
    GameObject itemPrefab3;
    [SerializeField]
    GameObject itemPrefab4;
    [SerializeField]
    GameObject itemPrefab5;
    [SerializeField]
    GameObject itemPrefab6;
    [SerializeField]
    GameObject itemPrefab7;
    [SerializeField]
    GameObject itemPrefab8;
    [SerializeField]
    GameObject MenuCrear;
    bool MovingCreated;
  
    void Start()
    {
        MovingCreated = false;
    }

    void Update()
    {
       
        if (MovingCreated == true) 
        {

            objectcr.SetActive(false);
           
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                objectcr.transform.position = hit.point;

            }
            objectcr.SetActive(true);
            objectcr.transform.Rotate(Input.mouseScrollDelta * 16);
            if (Input.GetMouseButtonDown(1))
            {

                MovingCreated = false;
            }
        }


       
    }

    public void MenuTienda()
    {
        MenuCrear.SetActive(true);
    }
    public void SpawnItem()
    {
        objectcr = Instantiate(itemPrefab, Vector3.zero, Quaternion.identity);
        MenuCrear.SetActive(false);
        MovingCreated = true;
    }

    public void SpawnItem2()
    {
        objectcr = Instantiate(itemPrefab2, Vector3.zero, Quaternion.identity);
        MenuCrear.SetActive(false);
        MovingCreated = true;
    }
    public void SpawnItem3()
    {
        objectcr = Instantiate(itemPrefab3, Vector3.zero, Quaternion.identity);
        MenuCrear.SetActive(false);
        MovingCreated = true;
    }
    public void SpawnItem4()
    {
        objectcr = Instantiate(itemPrefab4, Vector3.zero, Quaternion.identity);
        MenuCrear.SetActive(false);
        MovingCreated = true;
    }
    public void SpawnItem5()
    {
        objectcr = Instantiate(itemPrefab5, Vector3.zero, Quaternion.identity);
        MenuCrear.SetActive(false);
        MovingCreated = true;
    }
    public void SpawnItem6()
    {
        objectcr = Instantiate(itemPrefab6, Vector3.zero, Quaternion.identity);
        MenuCrear.SetActive(false);
        MovingCreated = true;
    }
    public void SpawnItem7()
    {
        objectcr = Instantiate(itemPrefab7, Vector3.zero, Quaternion.identity);
        MenuCrear.SetActive(false);
        MovingCreated = true;
    }
    public void SpawnItem8()
    {
        objectcr = Instantiate(itemPrefab8, Vector3.zero, Quaternion.identity);
        MenuCrear.SetActive(false);
        MovingCreated = true;
    }

}