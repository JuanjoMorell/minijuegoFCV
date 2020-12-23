using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlJuego : MonoBehaviour
{
    [SerializeField]
    GameObject casilla;

    [SerializeField]
    Vector3 centro = Vector3.zero;

    float size, gap;

    Vector3 esquina;

    public List<casilla> casillas = new List<casilla>();

    // Start is called before the first frame update
    void Start()
    {
        size = 0.15f;
        gap = 1.5f;
        esquina = centro - 2f*(size+gap)*Vector3.right - 2f*(size+gap)*Vector3.forward;

        for(int i=0; i<5; i++) {
            for(int j=0;j<5; j++) {
                GameObject miCasilla = Instantiate(casilla);
                miCasilla.transform.position=esquina+i*(size+gap)*Vector3.forward +j*(size+gap)*Vector3.right;
                miCasilla.transform.localScale = size*Vector3.one;
                miCasilla.GetComponent<casilla>().fila=i;
                miCasilla.GetComponent<casilla>().columna=j;
                miCasilla.GetComponent<casilla>().posicion = transform.position;
                miCasilla.GetComponent<casilla>().control = this;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ganar() {

    }
}
