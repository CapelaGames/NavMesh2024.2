using System;
using UnityEngine;

namespace Unity.AI.Navigation.Samples
{
    /// <summary>
    /// Prefab spawner with a key input
    /// </summary>
    public class SpawnPrefabOnKeyDown : MonoBehaviour
    {
        [SerializeField]
        GameObject prefab;
        
        [SerializeField]
        KeyCode keyCode;
        
        [SerializeField]
        Transform spawnedPrefabsHolder;

        Transform m_Transform;

        void Start()
        {
            m_Transform = transform;

            if (spawnedPrefabsHolder == null)
            {
                spawnedPrefabsHolder = m_Transform;
            }
        }

        void Update()
        {
            if (Input.GetKey(keyCode) && prefab != null)
            {
                for(int i = 0; i < 100; i++)
                {
                    Instantiate(prefab, m_Transform.position, m_Transform.rotation, spawnedPrefabsHolder);
                }
               
            }
        }
    }
}