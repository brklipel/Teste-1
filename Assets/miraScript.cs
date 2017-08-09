using UnityEngine;
using System.Collections;

public class miraScript : MonoBehaviour
{
    private float velocidade = 10;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        Cursor.visible = true;

        Cursor.lockState = CursorLockMode.Locked;

        transform.Translate(Input.GetAxis("Mouse X") * velocidade * Time.deltaTime, Input.GetAxis("Mouse Y") * velocidade * Time.deltaTime, 0);
    }
}
