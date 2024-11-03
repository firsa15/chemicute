using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public Transform[] wayPoints;
    public float moveSpeed;
    private int currentPoints;

    public GameObject molekul;

    public bool molekul_obj = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (molekul.transform.position == wayPoints[currentPoints].position)
        {
            currentPoints++;
        }
        if (currentPoints >= wayPoints.Length)
        {
            currentPoints = 0;
        }
        if (molekul_obj == true)
        {
            molekul.transform.position = Vector3.MoveTowards(molekul.transform.position, wayPoints[0].position, moveSpeed * Time.deltaTime);
        }

        if (molekul_obj == true)
        {
            StartCoroutine(Dealy());
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("hit");
        molekul_obj = true;
    }
    
    IEnumerator Dealy()
    {
        yield return new WaitForSeconds(10f);
    }
}
