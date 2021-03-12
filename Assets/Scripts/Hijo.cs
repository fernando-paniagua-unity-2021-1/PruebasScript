using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hijo : MonoBehaviour
{
    private void OnMouseDown() {
        //transform.Translate(Vector3.right, Space.World);//Traslación sobre el eje de coordenadas del mundo
        //transform.Translate(Vector3.right, Space.Self);//Traslación sobre el eje de coordenadas propio
        print("Global:" + transform.position.x);
        print("Local:" + transform.localPosition.x);
        transform.Translate(transform.forward, Space.World);
    }
}
