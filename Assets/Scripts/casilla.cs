using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class casilla : MonoBehaviour
{
    [SerializeField]
    Material encendida, apagada, select_en, select_ap;

    int estado = 0;

    public int fila, columna;
    public Vector3 posicion;
    MeshRenderer renderer;

    public controlJuego control;

    // Start is called before the first frame update
    void Start()
    {
        renderer=GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseEnter() {
        if (estado == 1) {
            renderer.material = select_en;
        } else {
            renderer.material = select_ap;
        }
         
    }

    void OnMouseExit() {
        if (estado == 1) {
            renderer.material = encendida;
        } else {
            renderer.material = apagada;
        }
    }

    void OnMouseDown() {
        if (estado == 1) {
            estado = 0;
            renderer.material = apagada;
        } else {
            estado = 1;
            renderer.material = encendida;
        }

        // Obtener casillas de la columna y fila
    }
}
