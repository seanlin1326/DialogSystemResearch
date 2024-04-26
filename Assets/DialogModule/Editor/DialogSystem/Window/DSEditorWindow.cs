using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
namespace DialogSystem.Windows
{
    public class DSEditorWindow : EditorWindow
    {
        [MenuItem("Window/CustomDialogSystem/Dialog Graph")]
        public static void ShowExample()
        {
            DSEditorWindow wnd = GetWindow<DSEditorWindow>("Dialog Graph");
          
        }
        private void OnEnable()
        {
            AddGraphView();
            AddStyles();
        }

        private void AddStyles()
        {
            StyleSheet stylesheet = (StyleSheet)EditorGUIUtility.Load("DialogSystem/DSVariables.uss");
            rootVisualElement.styleSheets.Add(stylesheet);
        }

        private void AddGraphView()
        {
            DSGraphView graphView = new DSGraphView();
            graphView.StretchToParentSize();
            rootVisualElement.Add(graphView);
        }
    }
}