using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Renderer fondo;
    public GameObject col;
    public List<GameObject> cols;
    public float floorSpeed = 2;
    public float contadorTiempo = 0;
    public Text tiempo;

    // Start is called before the first frame update
    void Start()
    {
        //AQUI SE CREA EL MAPA
        for(int i=0; i<100; i++)
        {
            
            cols.Add(Instantiate(col, new Vector2(-10 + i, -4.5f), Quaternion.identity));
        }
    }

    // Update is called once per frame
    void Update()
    {
        contadorTiempo += Time.deltaTime;
        tiempo.text = "" + contadorTiempo.ToString("f1");

        fondo.material.mainTextureOffset = fondo.material.mainTextureOffset + new Vector2 (0.10f, 0) * Time.deltaTime;
        
        //SE MUEVE EL SUELO
        for(int i=0; i < cols.Count; i++)
        {
            cols[i].transform.position = cols[i].transform.position + new Vector3(-1,0,0) * Time.deltaTime * floorSpeed;
        }
    }
}
