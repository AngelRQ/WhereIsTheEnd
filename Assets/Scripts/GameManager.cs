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
    public List<GameObject> obstaculos;
    public float floorSpeed = 2;
    public float contadorTiempo = 0;
    public Text tiempo;
    public GameObject calavera;
    public GameObject picos;
    public GameObject piedras;
    public GameObject charco;
    public GameObject cactus;

    // Start is called before the first frame update
    void Start()
    {
        //AQUI SE CREA EL MAPA
        for(int i=0; i<100; i++)
        {
            
            cols.Add(Instantiate(col, new Vector2(-10 + i, -4.5f), Quaternion.identity));
        }

        //SE CREAN LOS OBSTACULOS
        obstaculos.Add(Instantiate(calavera, new Vector2(5 , -3.5f), Quaternion.identity));
        obstaculos.Add(Instantiate(picos, new Vector2(20, -3.5f), Quaternion.identity));
        obstaculos.Add(Instantiate(piedras, new Vector2(43, -3.5f), Quaternion.identity));
        obstaculos.Add(Instantiate(charco, new Vector2(65, -3.5f), Quaternion.identity));
        obstaculos.Add(Instantiate(cactus, new Vector2(89, -3.5f), Quaternion.identity));
        //CADA OBSTACULO TIENE SUS PROPIAS COORDENADAS EN Y

    }

    // Update is called once per frame
    void Update()
    {
        //SISTEMA DE DISTANCIA
        contadorTiempo += Time.deltaTime;
        tiempo.text = "" + contadorTiempo.ToString("f1");


        //AQUI SE MUEVE EL FONDO
        fondo.material.mainTextureOffset = fondo.material.mainTextureOffset + new Vector2 (0.10f, 0) * Time.deltaTime;
        
        //SE MUEVE EL SUELO
        for(int i=0; i < cols.Count; i++)
        {
            if(cols[i].transform.position.x <= -10){
                cols[i].transform.position = new Vector3(10, -4.5f, 0);
            }
            cols[i].transform.position = cols[i].transform.position + new Vector3(-1,0,0) * Time.deltaTime * floorSpeed;
        }

        //AQUI SE MUEVEN LOS OBSTACULOS
        for (int i = 0; i < obstaculos.Count; i++)
        {
            if (obstaculos[i].transform.position.x <= -10)
            {
                float randomObst = Random.Range(1, 99);
                obstaculos[i].transform.position = new Vector3(randomObst, -3.5f, 0); //se vuelven a generar en -3.5f en eje y
            }
            obstaculos[i].transform.position = obstaculos[i].transform.position + new Vector3(-1, 0, 0) * Time.deltaTime * floorSpeed;
        }
    }
}
