using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    public int score;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Goal")
        {
            this.gameObject.transform.position = GameObject.Find("PozicijaLopte").transform.position;
            this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            score++;
        }
    }

    public void Update()
    {
        GameObject.Find("ScoreboardText").GetComponent<TextMesh>().text = score.ToString();
    }

}
