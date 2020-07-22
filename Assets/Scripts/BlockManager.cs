using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour
{

    [SerializeField]
    private Sprite[] blocksSprites;
    [SerializeField]
    private string[] blocksNames;
    [SerializeField]
    private bool[] areBlocksSolid;

    public Block[] blocks;

    private void Awake()
    {
        blocks = new Block[blocksSprites.Length];

        for (int i = 0; i < blocksSprites.Length; i++)
        {
            blocks[i] = new Block(i, blocksNames[i], blocksSprites[i], areBlocksSolid[i]);
        }
    }
}

public class Block
{
    public int id;
    public string name;
    public Sprite sprite;
    public bool isSolid;
    
    public Block(int blockID, string blockName, Sprite blockSprite, bool isBlockSolid)
    {
        id = blockID;
        name = blockName;
        sprite = blockSprite;
        isSolid = isBlockSolid;
    }
}
