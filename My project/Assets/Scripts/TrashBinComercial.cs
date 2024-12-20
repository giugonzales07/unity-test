using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashBinComercial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision){
        switch (collision.gameObject.tag)
        {
            case "bag_comercial":
                FindObjectOfType<GameManager>().WinPoints();
                FindObjectOfType<Timer>().AddTime();
                //FindObjectOfType<GameManager>().score += 2;
                StartCoroutine(DestroyAfterFrame(collision.gameObject));
                break;
            case "bag_recy":
                FindObjectOfType<GameManager>().LosePoints();
                FindObjectOfType<Timer>().SubTime();
                StartCoroutine(DestroyAfterFrame(collision.gameObject));
                break;
            case "bag_general":
                FindObjectOfType<GameManager>().LosePoints();
                FindObjectOfType<Timer>().SubTime();
                StartCoroutine(DestroyAfterFrame(collision.gameObject));
                break;
        }
    }

    private IEnumerator DestroyAfterFrame(GameObject obj){
        yield return null; // Espera um quadro
        DestroyImmediate(obj);
    }
    
}
