using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level_block_generator : MonoBehaviour {
    public levelBlock levelBlock; // bloque del nivel 
    public levelBlock LastLevelBlock;//Ultimo Bloque colocado 
    public levelBlock currentLevelBlock;
 
	// Use this for initialization
	void Start () {
        AddNewBlock();
	}
	
	// Update is called once per frame
	void Update () {
        float xcam = Camera.main.transform.position.x;
        float xold = LastLevelBlock.exitPoint.position.x;
        if (xcam> xold+ LastLevelBlock.width/2)
        {
            RemoveOldBlock();

        }
	}
    public void AddNewBlock()
    {
        levelBlock block = (levelBlock)Instantiate(levelBlock);
        block.transform.SetParent(this.transform, false);

        Vector3 blockPosition = Vector3.zero;
        blockPosition = new Vector3(LastLevelBlock.exitPoint.position.x+block.width/2,
            LastLevelBlock.exitPoint.position.y, 
            LastLevelBlock.exitPoint.position.z);
        block.transform.position = blockPosition;
        currentLevelBlock = block;
    }
    public void RemoveOldBlock()
    {
        Destroy(LastLevelBlock.gameObject);
        LastLevelBlock = currentLevelBlock;
        AddNewBlock();

    }
}
