using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour
{
    private void Awake() {
        print("AWAKE CUBO");
    }

    // Start is called before the first frame update
    void Start()
    {
        print("START CUBO");
    }

    // Update is called once per frame
    private void FixedUpdate() {//1 VEZ CADA t SEGUNDOS
        print("FIXED UPDATE CUBO");
    }

    void Update()//1 VEZ POR FRAME
    {
        print("UPDATE CUBO");
    }

    private void LateUpdate() {//1 VEZ POR FRAME, DESPUÉS DE TODOS LOS UPDATES DE TODOS LOS SCRIPTS
        print("LATE UPDATE CUBO");
    }

    private void OnDestroy() {
        print("DESTRUYENDO CUBO");
    }

    private void OnEnable() {
        print("ACTIVANDO CUBO");
    }

    private void OnDisable() {
        print("DESACTIVANDO CUBO");
    }
    private void OnApplicationQuit() {
        print("SALIENDO DE LA APLICACIÓN (CUBO)");
    }
}
