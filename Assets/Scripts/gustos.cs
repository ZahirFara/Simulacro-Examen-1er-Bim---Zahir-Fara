using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gustos : MonoBehaviour
{
    public string codigoHelado;
    public float gramosHelado;
    float precioGramo = 1.250f;
    // Start is called before the first frame update
    void Start()
    {
        if (codigoHelado == "" || gramosHelado > 3000 || gramosHelado < 250)
        {
            Debug.Log("Los valores son validos");
            return;
        }
        if (codigoHelado == "FRU")
        {
            Debug.Log("El precio sería " + gramosHelado * precioGramo * 0.9f);
        }
        else if (codigoHelado == "CHO")
        {
            Debug.Log("El precio sería " + gramosHelado * precioGramo);
        }
        else if (codigoHelado == "DDL")
        {
            Debug.Log("El precio sería " + gramosHelado * precioGramo);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
