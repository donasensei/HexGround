using HexaGround;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltGrid : MonoBehaviour
{
    public GameObject hexPrefab;

    public int gridWidth = 11; //그리드 가로길이
    public int gridHeight = 11; //그리드 세로길이
 
    float hexWidth = 1.732f; 
    float hexHeight = 2.0f;
    public float gap = 0.0f; // 간격

    public Vector3 startOffset;
    
    [SerializeField]
    Vector3 generatePos; //시작지점 변수


    public HexaCoordinate[,] hexaCoordinates;
    private List<GameObject> gridObjects = new List<GameObject>();

    void Start()
    {
        AutoCreateGrid();
    }
 
    void AddGap()
    {
        //가로길이에 스칼라곱
        hexWidth += hexWidth * gap; 
        hexHeight += hexHeight * gap;
    }
 
    void CalcStartPos(Vector3 offsetPos)
    {
        float offset = 0;
        if (gridHeight / 2 % 2 != 0)
        {
            offset = hexWidth / 2;
        }

        // 좌표계산
        float x = -hexWidth * (gridWidth / 2) - offset;
        float z = hexHeight * 0.75f * (gridHeight / 2);
 
        generatePos = new Vector3(x, 0, z) + offsetPos;
    }
 
    Vector3 CalcWorldPos(Vector2 gridPos)
    {
        float offset = 0;
        if (gridPos.y % 2 != 0)
        {
            offset = hexWidth / 2;
        }
        // 좌표계산
        float x = generatePos.x + gridPos.x * hexWidth + offset;
        float z = generatePos.z - gridPos.y * hexHeight * 0.75f;
 
        return new Vector3(x, generatePos.y, z);
    }
 
    void CreateGrid(Vector3 pos)
    {

    }

    public void AutoCreateGrid()
    {
        AddGap();
        CalcStartPos(startOffset); //계산된 시작지점 저장됨
        InitHexCoordMap(gridWidth, gridHeight);
        // 그리드 생성
        for (int y = 0; y < gridHeight; y++)
        {
            for (int x = 0; x < gridWidth; x++)
            {
                GameObject hexObject = Instantiate(hexPrefab, transform);
                Transform hex = hexObject.transform;
                gridObjects.Add(hexObject);
                Vector2 gridPos = new Vector2(x, y);
                hexaCoordinates[y, x] = new HexaCoordinate(x, y);
                hex.position = CalcWorldPos(gridPos);
                hex.name = "Hexagon" + x + "|" + y;
            }
        }

        Debug.Log("Hex Map Done");
    }

    public void InitHexCoordMap(int width, int height)
    {
        Debug.Log("Init Hex CoordMap");
        hexaCoordinates = new HexaCoordinate[height, width];
    }

    public void ClearGrid()
    {
        Debug.Log("Clear Grid");
        int totalCount = gridObjects.Count;
        for(int index = totalCount - 1; index >= 0; --index)
        {
            DestroyImmediate(gridObjects[index]);
        }
        gridObjects.Clear();
    }
}