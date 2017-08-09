using UnityEngine;
using System.Collections;
using System.IO;

public class ValoerReferencia : MonoBehaviour
{
    public GameObject player1Bazuca, player1Rifle, player1Pistola, ComBazuca, ComPistola, ComRifle;

    protected string _GCCtest; // Possível, mas difícil encontrar, retorna valor irreconhecível pela CheatEngine.

    public string GCCtest
    { // Impossível encontrar! Este objeto parece na verdade não existir na memória.

        get
        {
             return CodificarAtributos.DecodeString(_GCCtest);
        }

        set
        {
            _GCCtest = CodificarAtributos.EncodeString(value);
        }
    }

    void Start()
    {

        /*GCCtest = "UNIDADE1PLAYER VIDA 50 FORCA 20 DANO 10 QTDTIRO 3 PESO 17 \nUNIDADE2PLAYER VIDA 40 FORCA 30 DANO 10 QTDTIRO 2 PESO 18 \nUNIDADE3PLAYER VIDA 30 FORCA 40 DANO 10 QTDTIRO 1 PESO 19 \n UNIDADE1COM VIDA 50 FORCA 20 DANO 10 QTDTIRO 3 PESO 17 \nUNIDADE2COM VIDA 40 FORCA 30 DANO 10 QTDTIRO 2 PESO 18 \nUNIDADE3COM VIDA 30 FORCA 40 DANO 10 QTDTIRO 1 PESO 19";
        StreamWriter sw = new StreamWriter(Application.dataPath + "/ArquivoParaEscrita.txt"); //pode ser *.ini
        sw.WriteLine(_GCCtest);
        sw.Close(); // fecha o arquivo, para o SO poder usá-lo para outras coisa */

        StreamReader sw = new StreamReader(Application.dataPath + "/ArquivoParaEscrita.txt"); //pode ser *.ini

        _GCCtest = sw.ReadToEnd();

        sw.Close();

        char[] delimitadores = new char[] {' ', '\n'};

        string tempValoresEmString = GCCtest;

        string[] organizaValores = tempValoresEmString.Split(delimitadores, System.StringSplitOptions.RemoveEmptyEntries);

        player1Bazuca.GetComponent<BazucaScript>().Vida = System.Convert.ToInt32(organizaValores[2]);
        player1Bazuca.GetComponent<BazucaScript>().Forca = System.Convert.ToInt32(organizaValores[4]);
        player1Bazuca.GetComponent<BazucaScript>().Dano = System.Convert.ToInt32(organizaValores[6]);
        player1Bazuca.GetComponent<BazucaScript>().QtdTiro = System.Convert.ToInt32(organizaValores[8]);
        player1Bazuca.GetComponent<BazucaScript>().Peso = System.Convert.ToInt32(organizaValores[10]);

        player1Pistola.GetComponent<PistolaScript>().Vida = System.Convert.ToInt32(organizaValores[13]);
        player1Pistola.GetComponent<PistolaScript>().Forca = System.Convert.ToInt32(organizaValores[15]);
        player1Pistola.GetComponent<PistolaScript>().Dano = System.Convert.ToInt32(organizaValores[17]);
        player1Pistola.GetComponent<PistolaScript>().QtdTiro = System.Convert.ToInt32(organizaValores[19]);
        player1Pistola.GetComponent<PistolaScript>().Peso = System.Convert.ToInt32(organizaValores[21]);

        player1Rifle.GetComponent<RifleScript>().Vida = System.Convert.ToInt32(organizaValores[24]);
        player1Rifle.GetComponent<RifleScript>().Forca = System.Convert.ToInt32(organizaValores[26]);
        player1Rifle.GetComponent<RifleScript>().Dano = System.Convert.ToInt32(organizaValores[28]);
        player1Rifle.GetComponent<RifleScript>().QtdTiro = System.Convert.ToInt32(organizaValores[30]);
        player1Rifle.GetComponent<RifleScript>().Peso = System.Convert.ToInt32(organizaValores[32]);

        ComBazuca.GetComponent<BazucaScript>().Vida = System.Convert.ToInt32(organizaValores[35]);
        ComBazuca.GetComponent<BazucaScript>().Forca = System.Convert.ToInt32(organizaValores[37]);
        ComBazuca.GetComponent<BazucaScript>().Dano = System.Convert.ToInt32(organizaValores[39]);
        ComBazuca.GetComponent<BazucaScript>().QtdTiro = System.Convert.ToInt32(organizaValores[41]);
        ComBazuca.GetComponent<BazucaScript>().Peso = System.Convert.ToInt32(organizaValores[43]);

        ComPistola.GetComponent<PistolaScript>().Vida = System.Convert.ToInt32(organizaValores[46]);
        ComPistola.GetComponent<PistolaScript>().Forca = System.Convert.ToInt32(organizaValores[48]);
        ComPistola.GetComponent<PistolaScript>().Dano = System.Convert.ToInt32(organizaValores[50]);
        ComPistola.GetComponent<PistolaScript>().QtdTiro = System.Convert.ToInt32(organizaValores[52]);
        ComPistola.GetComponent<PistolaScript>().Peso = System.Convert.ToInt32(organizaValores[54]);

        ComRifle.GetComponent<RifleScript>().Vida = System.Convert.ToInt32(organizaValores[57]);
        ComRifle.GetComponent<RifleScript>().Forca = System.Convert.ToInt32(organizaValores[59]);
        ComRifle.GetComponent<RifleScript>().Dano = System.Convert.ToInt32(organizaValores[61]);
        ComRifle.GetComponent<RifleScript>().QtdTiro = System.Convert.ToInt32(organizaValores[63]);
        ComRifle.GetComponent<RifleScript>().Peso = System.Convert.ToInt32(organizaValores[65]);
    }

    void OnGUI()
    {

    }

}
