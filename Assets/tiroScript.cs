using UnityEngine;
using System.Collections;

public class tiroScript : MonoBehaviour
{
    public int forca;
    bool lancou = false;
    public int dano;

    Rigidbody rgb;

    void Start()
    {
        rgb = GetComponent<Rigidbody>();
    }

    public void mudaVelocidade(int valor)
    {
        forca = valor;
    }

    public void MudaDano(int valor)
    {
        dano = valor;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Terreno")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Per")
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        //transform.Translate(0, 0, forca * Time.deltaTime);
        if (lancou == false)
        {
            rgb.velocity = transform.TransformDirection(new Vector3(0, 0, forca));
            lancou = true;
        }
    }
}
