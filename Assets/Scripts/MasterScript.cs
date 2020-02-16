using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterScript : MonoBehaviour
{
    // Start is called before the first frame update

    public float money;
 
    // Update is called once per frame
    void Update()
    {

    }
    public void CoinCollection()
    {
        money += 1;
    }
}
