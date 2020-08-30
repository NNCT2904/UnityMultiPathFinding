using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigation: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }

    public void Case1()
    {
        SceneManager.LoadScene(1);
    } 
    
    public void Case2()
    {
        SceneManager.LoadScene(2);
    } 
    
    public void Case3()
    {
        SceneManager.LoadScene(3);
    } 
    
    public void Case4()
    {
        SceneManager.LoadScene(4);
    }
}
