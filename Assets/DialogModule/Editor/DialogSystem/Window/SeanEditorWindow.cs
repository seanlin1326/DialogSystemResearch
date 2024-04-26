using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
namespace DialogSystem
{
    public class SeanEditorWindow : EditorWindow
    {
        [MenuItem("Window/Sean/Dialog Graph")]
        public static void ShowExample()
        {
            SeanEditorWindow wnd = GetWindow<SeanEditorWindow>("Dialog Graph");
          
        }

      
    }
}