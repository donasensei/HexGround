using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(AltGrid))]
[CanEditMultipleObjects]
public class AltGridEditor: Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        AltGrid altGrid = target as AltGrid;
        if(GUILayout.Button("Generate HexaGrid"))
        {
            altGrid.AutoCreateGrid();
        }
    }
}
