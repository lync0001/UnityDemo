using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BlindSwitch : MonoBehaviour
{
    public GameObject blind;
    public GameObject textO;
    public GameObject textC;
    public int speed;

    void Start()
    {
        textC.SetActive(false);
        textO.SetActive(false);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            textC.SetActive(true);
            textO.SetActive(true);
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            textO.SetActive(false);
            textC.SetActive(false);
        }
    }

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.Q))
            {         
               blind.transform.Translate(Vector3.up * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.E))
            {
               blind.transform.Translate(Vector3.down * Time.deltaTime);
            }
        }
    }
}