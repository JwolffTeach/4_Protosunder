using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("StartLevel", 2f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void StartLevel() {
        SceneManager.LoadScene(1);
    }
}
