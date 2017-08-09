using UnityEngine;
using System.Collections;

public abstract class PersonagemsScript : MonoBehaviour {

    public GameObject mira, braco, pontaArma;
    public tiroScript tiroscript;
    protected int vida, forca, dano, qtdTiros, peso;
   

    public int Vida
    {
        set
        {
            vida = value;
        }
    }

    public int Forca
    {
        set
        {
            forca = value;
        }
    }

    public int Dano
    {
        set
        {
            dano = value;
        }
    }

    public int QtdTiro
    {
        set
        {
            qtdTiros = value;
        }
    }

    public int Peso
    {
        set
        {
            peso = value;
        }
    }

    public abstract void Atirar();

    virtual protected void OnCollisionEnter(Collision collision)
    {

    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	protected void DefinindoMorte ()
    {
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }
}
