using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JeuBilles : MonoBehaviour
{
    [SerializeReference] private GameObject _bille;
    [SerializeReference] private GameObject _plateforme;
    [SerializeReference] private GameObject _cible1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        _plateforme.SetActive(false);
    }
}
