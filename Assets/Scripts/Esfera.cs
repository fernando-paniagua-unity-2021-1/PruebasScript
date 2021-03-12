using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esfera : MonoBehaviour
{
    public GameObject cubo;
    private void Start() {
        //enabled -- Indica si un componente está disponible o no disponble
        if (GetComponent<SphereCollider>().enabled==true){//LECTURA
            GetComponent<SphereCollider>().enabled=false;//ASIGNACIÓN
        } else {
            GetComponent<SphereCollider>().enabled=true;//ASIGNACIÓN
        }
        //GameObject activo o no
        if (cubo.activeSelf){
            cubo.SetActive(false);
        } else {
            cubo.SetActive(true);
        }
        //Nombre del objeto. No es único.
        print(gameObject.name);
        GameObject.Find("Capsule").SetActive(false);
        //Tag
        print(gameObject.tag);
        //Transform
        transform.localScale = new Vector3(1.25f,1.25f,1.25f);
        transform.Translate(Vector3.right);
        transform.Rotate(Vector3.right);
    }
}
