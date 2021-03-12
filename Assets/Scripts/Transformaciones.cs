using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transformaciones : MonoBehaviour
{
    public GameObject cilindro;
    private void Awake() {
        //Destroy(this.gameObject,5);//Se destruye después de un rato
    }
    private void Update() {
        //GameObject esfera = GameObject.Find("Sphere");
        //transform.position = Vector3.MoveTowards(transform.position, esfera.transform.position, Time.deltaTime);
        //Vector3.RotateTowards
    }
    private void OnMouseDown() {
        //transform.Translate(Vector3.right);//Desplazamiento relativo
        //transform.position = new Vector3(3,0,-6);//Desplazamiento absoluto
        //transform.Rotate(new Vector3(10,0,0));//Rotación relativa
        //transform.rotation = Quaternion.Euler(45,0,0);//Rotación absoluta que debe realizarse convirtiendo los ángulos Euler a Quaternion
        //transform.localScale*=1.1f;//Escalado relativo
        //transform.localScale = new Vector3(2,1,2);//Escalado absoluto

        GameObject esfera = GameObject.Find("Sphere");
        Vector3 vectorDiferencia = esfera.transform.position - transform.position;
        print("Distancia:" + vectorDiferencia.magnitude);//Distancia en línea recta entre el inicio y el fin del vector
        print("Direccion:" + vectorDiferencia.normalized);//Convierte el vector de dirección en uno equivalente de magnitud 1

        //Vector3 nuevaPosicion = transform.position * 1.1f;//Modificación lineal en los tres ejes (si es 0, no hace nada)
        //transform.position = nuevaPosicion;
        //transform.LookAt(esfera.transform, vectorDiferencia);
        Instantiate(cilindro, transform.position, Quaternion.identity, transform);//Quaternion.identity --> Equivalente a 0,0,0 en rotación
    }
}
