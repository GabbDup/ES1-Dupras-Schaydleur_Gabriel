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
    
    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerEnter(Collider _terminus)
    {
        Debug.Log("I'm In!");
        for(int i = 0; i<6; i++)
        {
            _time += Time.deltaTime*4;
            print(_time);
            if(_time == 5)
            {
                Redemarrer();
            }
        }
    }

    void Redemarrer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
