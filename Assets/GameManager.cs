using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    public GameObject selectedZombie;
    public List<GameObject>zombies; 
    public Vector3 selectedSize;
    public Vector3 defaultSize;
    // Start is called before the first frame update
    void Start()
    {
        SelectZombie(selectedZombie);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SelectZombie(GameObject newZombie){
        newZombie.transform.localScale = selectedSize;
    }
}
