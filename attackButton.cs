using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class attackButton : MonoBehaviour {

    public float attackDuration = 0.3f;
    public bool attacking;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Fire1"))
        {
            attacking = true;
        }
        EnableDamage();
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Enemy")
        {
            if(col.tag == "Enemy")
            {
                col.SendMessage("LevaDano", 1, SendMessageOptions.DontRequireReceiver);
            }
        }
        attacking = false;
    }
    void EnableDamage()
    {
        if (attacking == true) return;
        attacking = true;
        StartCoroutine("DisableDamage");
    }
    IEnumerator DisableDamage()
    {
        yield return new WaitForSeconds(attackDuration);
        attacking = false;
    }
}
