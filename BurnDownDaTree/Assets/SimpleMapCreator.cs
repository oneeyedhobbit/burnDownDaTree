using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Just makes a simple map
public class SimpleMapCreator  {

	
	static BDDT.Map createSimpleMap ()
    {
        BDDT.Map simpleMap = new BDDT.Map();
        simpleMap.boardChunks = new BDDT.BoardChunk[1];
        return simpleMap;
    }
}
