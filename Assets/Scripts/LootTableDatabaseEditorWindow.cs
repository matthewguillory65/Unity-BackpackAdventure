using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class LootTableDatabaseEditorWindow : EditorWindow
{
    private GUIStyle Header = new GUIStyle();
    public static List<LootTable> tables = new List<LootTable>();
    static string path;
    public static List<string> allFiles = new List<string>();

    [MenuItem("Tools/LootTableDatabase")]
	static void Init()
    {
        var window = (LootTableDatabaseEditorWindow)GetWindow(typeof(LootTableDatabaseEditorWindow));
        window.Populate();
        window.Show();

    }
    
    private void Populate()
    {
        allFiles = new List<string>();
        tables = new List<LootTable>();
        path = Application.dataPath + "/Resources/Tables/";
        allFiles.AddRange(Directory.GetFiles(path, "*.asset"));
        foreach (var file in allFiles)
        {
            var relpath = file.Substring(path.Length - file.Length);
            var table = AssetDatabase.LoadAssetAtPath<LootTable>(relpath);
            tables.Add(table);
        }
    }

    private void OnGUI()
    {
        Header.alignment = TextAnchor.UpperCenter;
        Header.fontStyle = FontStyle.BoldAndItalic;
        Header.fontSize = 50;
        Header.normal.textColor = Color.cyan;
        GUILayout.Label("You shouldn't be here...", Header);
        GUILayout.Space(25);
        if (GUILayout.Button("This is a Button")) { }
        foreach (var file in allFiles)
            EditorGUILayout.TextField("Table File:", file);
    }
}
