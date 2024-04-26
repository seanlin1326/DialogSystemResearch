using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEditor;
using System;
using UnityEngine.UIElements;
using DialogSystem.Elements;

namespace DialogSystem.Windows
{
    public class DSGraphView : GraphView
    {
        public DSGraphView()
        {
            AddManipulators();
            AddGridBackground();

            CreateNode();
            AddStyles();
        }

        private void CreateNode()
        {
            DSNode node = new DSNode();
            node.Init();
            node.Draw();
            AddElement(node);
        }

        private void AddManipulators()
        {
            SetupZoom(ContentZoomer.DefaultMinScale, ContentZoomer.DefaultMaxScale);
            this.AddManipulator(new ContentDragger());
           
        }

        private void AddGridBackground()
        {
            GridBackground gridBackground = new GridBackground();
            gridBackground.StretchToParentSize();
            Insert(0, gridBackground);
        }
        private void AddStyles()
        {
            StyleSheet stylesheet = (StyleSheet)EditorGUIUtility.Load("DialogSystem/DSGrapthViewStyles.uss");
            styleSheets.Add(stylesheet);
        }
    }
}