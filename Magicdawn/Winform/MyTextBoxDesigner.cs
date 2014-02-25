using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace Magicdawn.Winform
{
    /// <summary>
    /// 用于DawnTextBox的设计器
    /// </summary>
    class MyTextBoxDesigner : System.Windows.Forms.Design.ControlDesigner
    {
        private DesignerActionListCollection actionList;
        public override DesignerActionListCollection ActionLists
        {
            get
            {
                if (actionList == null)
                {
                    actionList = new DesignerActionListCollection();

                    //collection添加new 的东西
                    actionList.Add(new MyTextBoxActionList(this.Control as MyTextBox));
                }
                return actionList;
            }
        }
    }
}
