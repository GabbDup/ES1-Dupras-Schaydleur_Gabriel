using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetctionCible : MonoBehaviour
{
   [SerializeReference] private GameObject _bille;
   [SerializeReference] private GameObject _cible1;
   [SerializeReference] private GameObject _cible2;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("cible"))
        {
            Destroy(collision.gameObject);
        }
    }

}
