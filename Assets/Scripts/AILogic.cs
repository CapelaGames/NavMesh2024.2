using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))] //Nice to have
public class AILogic : MonoBehaviour
{
    //Reference to other things
    public Transform key;
    public MoveDoor door;
    public Transform player;
    GameObject test;

    //Self reference
    public RandomWalk randomWalk;
    private NavMeshAgent _agent;

    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (door.isOpen == false && key != null)
        {
            _agent.destination = key.position;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (key.gameObject == other.gameObject)//other.GetComponent<Key>() != null)
        {
            door.unlockDoor = true;
            Destroy(other.gameObject);
        } 
    }


}
