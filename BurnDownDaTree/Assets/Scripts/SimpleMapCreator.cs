using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Just makes a simple map
public class SimpleMapCreator : MonoBehaviour {

	public GameObject tileFab;

	void Start()
	{
		for (int i = 0; i < 8; ++i)
		{
			for (int j = 0; j < 8; ++j)
			{
				Instantiate(tileFab, new Vector3(i, 0, j), Quaternion.identity);
			}
		}
	}

	static Map createSimpleMap ()
    {
        Map simpleMap = new Map();
        simpleMap.boardChunks = new BoardChunk[1];
        return simpleMap;
    }
}
