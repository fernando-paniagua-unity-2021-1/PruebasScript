using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cilindro : MonoBehaviour
{
    public float speed;
    private void Update() {
        float h = Input.GetAxis("Horizontal");//[-1,1]
        float v = Input.GetAxis("Vertical");//[-1,1]
        transform.Translate(new Vector3(h*Time.deltaTime*speed, 0, v*Time.deltaTime*speed));

        if (Input.GetKey(KeyCode.Y)){//Mientras está pulsado
            transform.Translate(Vector3.up * Time.deltaTime);
        }
        if (Input.GetKeyUp(KeyCode.Y)){//Al soltar la tecla
            transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Escape)){
            print("HAS PULSADO ESCAPE");
        }

        if (Input.GetButton("Fire1")){
            //transform.Translate(Vector3.up * Time.deltaTime);
        }
        if (Input.GetButton("Fire2")){
            transform.Translate(Vector3.down * Time.deltaTime);
        }
        if (Input.GetButtonDown("Gatillo")){
            print("Gatillo");
        }
        if (moviendo){
            Vector3 currentPosition = Camera.main.WorldToScreenPoint(transform.position);
            Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, currentPosition.z);
            transform.position = Camera.main.ScreenToWorldPoint(newPosition);
        }
    }
    public bool moviendo=false;
    private void OnMouseDown() {
        moviendo=true;
    }
    private void OnMouseUp() {
        moviendo=false;    
    }
}