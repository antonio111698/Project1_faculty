using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;
    [SerializeField] Attacker[] attackerPrefabArray;
    [Range(0,5)][SerializeField]private static int enemies = 3;

    bool spawn = true;
    
    IEnumerator Start()
    {
       
        for(int i=0;i<enemies;i++)
        {
            
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttacker();
        }
        StopSpawners();
    }

    public void StopSpawning()
    {
        spawn = false;
    }

    private void StopSpawners()
    {
        AttackerSpawner[] spawnerArray = FindObjectsOfType<AttackerSpawner>();
        foreach(AttackerSpawner spawner in spawnerArray )
        {
            spawner.StopSpawning();
        }
    }

    private void SpawnAttacker()
    {
        var attackerIndex = Random.Range(0, attackerPrefabArray.Length);
        Spawn(attackerPrefabArray[attackerIndex]);
        
    }

    private void Spawn(Attacker myAttacker)
    {
        Attacker newAttacker = Instantiate
            (myAttacker, transform.position, transform.rotation) as Attacker;
        newAttacker.transform.parent = transform;
    }
}
   
