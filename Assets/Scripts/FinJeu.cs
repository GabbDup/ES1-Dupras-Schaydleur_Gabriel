using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinJeu : MonoBehaviour
{

    [SerializeReference] private GameObject _terminus;
    [SerializeReference] private GameObject _bille;

    float _time = 0f;

    bool _jeuFini = false;
    
    void Update() 
    {
        if(_jeuFini == true)
        {
            _time += Time.deltaTime;
            if(_time >= 5f)
            {
                Redemarrer();
            }
        }
    }
    void OnTriggerEnter(Collider _terminus)
    {
        _jeuFini = true;
    }

    void Redemarrer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
