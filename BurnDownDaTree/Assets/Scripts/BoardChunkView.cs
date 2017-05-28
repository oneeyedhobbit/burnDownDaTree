using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This is how we 'see' the boardchunks
// We chunk up the board so that it is easy
// to load in new pieces of the board

// The boardchunk doesn't really do much each frame
// It just loads tile views when it is visible
// And will unload them when it isn't visible

public class BoardChunkView : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// turn ground objects into TileViews
	}
	
	// Update is called once per frame
	void Update () {

		// The boardchunk view doesn't change much itself each frame
         
	}
}
