using UnityEngine;
using System.Collections;
using System;

public class BazucaScript : PersonagemsScript
{
    public override void Atirar()
    {

        Vector3 vT = new Vector3(mira.transform.position.x, mira.transform.position.y, transform.position.z);

        braco.transform.LookAt(vT);

        pontaArma.transform.LookAt(mira.transform);

        if (Input.GetMouseButtonDown(0))
        {
            tiroscript.mudaVelocidade(forca);

            tiroscript.MudaDano(dano);

            Instantiate(tiroscript, pontaArma.transform.position, pontaArma.transform.rotation);
        }
    }

    protected override void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Tiro")
        {
            vida -= tiroscript.dano;
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Atirar();
        DefinindoMorte();
    }
}
