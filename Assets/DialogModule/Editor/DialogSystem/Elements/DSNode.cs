using DialogSystem.Enum;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine.UIElements;
namespace DialogSystem.Elements
{
    public class DSNode : Node
    {
        public string DialogName { get; set; }

        public List<string> Choices
        {
            get; set;
        }

        public string Text
        {
            get; set;
        }

        public DSDialogueType DialogType
        {
            get; set;
        }

        public void Init()
        {
            DialogName = "DialogName";
            Choices = new List<string>();
            Text = "Dialog Text";
        }

        public void Draw()
        {
            //title container
            TextField dialogNameTextField = new TextField()
            {
                value = DialogName
            };
            //input container
            titleContainer.Insert(0, dialogNameTextField);
            Port inputPort = InstantiatePort(Orientation.Horizontal,Direction.Input,Port.Capacity.Multi,typeof(bool));
            inputPort.portName = "Dialog Connection";
            inputContainer.Add(inputPort);
            // Extension Container
            VisualElement customDataContainer = new VisualElement();
            Foldout textFoldout = new Foldout()
            {
                text = "Dialog Text",
               
            };
            TextField textField = new TextField()
            {
                value = Text
            };
            textFoldout.Add(textField);
            customDataContainer.Add(textFoldout);
            extensionContainer.Add(customDataContainer);
        }
    }
}