using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JeuBilles : MonoBehaviour
{
    
    [SerializeReference] private GameObject _plateforme;
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
