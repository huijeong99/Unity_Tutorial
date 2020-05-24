using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float damage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;    
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.transform.name + "에게 데미지" + damage + "을 입혔습니다.");
        Destroy(this.gameObject);
    }
}
