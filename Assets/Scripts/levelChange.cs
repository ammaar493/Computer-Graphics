using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelChange : MonoBehaviour
{
    [SerializeField]
    string strtag;

    [SerializeField]
    string strscene;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag==strtag)
        {
            SceneManager.LoadScene(strscene);
        }
        
    }
}
