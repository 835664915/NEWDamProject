using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Today_Time : MonoBehaviour {


	void Update ()
    {
        this.GetComponent<Text>().text = System.DateTime.Now.ToString("yyyy/MM/dd \n HH:mm:ss");

    }


}
