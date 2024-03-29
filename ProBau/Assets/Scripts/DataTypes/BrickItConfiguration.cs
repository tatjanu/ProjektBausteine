﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct BrickItConfiguration
{
    public List<Vector3Int> brickExtends;
    public List<Color> colors;
    public int height;
    public int depth;
    public Mesh mesh;
    public Texture2D tex;
    public Transform transform;

}
