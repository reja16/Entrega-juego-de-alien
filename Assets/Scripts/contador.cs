using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class contador : MonoBehaviour

{
    [SerializeField]Animal A;
    public bool tempoLento = false;



    public Text cont;
    public float tiempito = 3f;
    // Start is called before the first frame update
    void Start()
    {
        cont.text = " " + tiempito;
    }

    // Update is called once per frame
    void Update()
    {
        
        
            tiempito -= Time.deltaTime;
            cont.text = " " + tiempito.ToString("f0");

        
    }
    public void ModoLentoOff()
    {
        tiempito -= Time.deltaTime;
        if (tiempito <= 0)
        {
            Time.timeScale = 1f;
            tempoLento = false;
        }
    }


}
