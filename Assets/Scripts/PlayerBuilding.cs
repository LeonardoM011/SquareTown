using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBuilding : MonoBehaviour {

    private BlockManager blockManager;

    private int currentBlockID = 0;
    private Block currentBlock;

    private GameObject blockTemplate;
    private SpriteRenderer currentRend;

    private bool isBModeOn = false;

    private void Awake()
    {
        blockManager = GetComponent<BlockManager>();
    }

    private void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            isBModeOn = !isBModeOn;

            if (blockTemplate != null)
            {
                Destroy(blockTemplate);
            }
            if (currentBlock == null)
            {
                if (blockManager.blocks[currentBlockID] != null)
                {
                    currentBlock = blockManager.blocks[currentBlockID];
                }
            }
            if (isBModeOn)
            {
                blockTemplate = new GameObject("CurrentBlockTemplate");
                currentRend = blockTemplate.AddComponent<SpriteRenderer>();
                currentRend.sprite = currentBlock.sprite;
            }
        }
    }
}
