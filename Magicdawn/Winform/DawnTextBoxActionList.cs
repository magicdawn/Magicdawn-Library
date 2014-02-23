using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace Magicdawn.Winform
{
    class DawnTextBoxActionList : DesignerActionList
    {
        private DawnTextBox txtbox;
        private DesignerActionUIService desUiSvc = null;

        public DawnTextBoxActionList(DawnTextBox txtbox)
            : base(txtbox)
        {
            this.txtbox = txtbox;

            //依赖注入,UIService
            this.desUiSvc = GetService(typeof(DesignerActionUIService))
                as DesignerActionUIService;
        }

        public override DesignerActionItemCollection GetSortedActionItems()
        {
            //获取action
            //目标 添加EnterSound WaterText
            DesignerActionItemCollection items = new DesignerActionItemCollection();

            //添加功能Header
            items.Add(new DesignerActionHeaderItem("功能", "Function"));
            items.Add(new DesignerActionHeaderItem("属性设置", "Property"));
            items.Add(new DesignerActionHeaderItem("水印文字", "WaterText"));

            //Multiline
            items.Add(new DesignerActionPropertyItem("Multiline", "多行模式","Function"));
            //EnterSound
            items.Add(new DesignerActionPropertyItem("EnterSound", "回车警告声",
                "Function", "按回车键的警告声,默认false关闭"));
            //EnableHighlightBorder
            items.Add(new DesignerActionPropertyItem("EnableHighlightBorder", "高亮边框",
                "Function"));

            //一些属性设置
            items.Add(new DesignerActionPropertyItem("Text", "文字", "Property"));// 文字

            //WaterText
            items.Add(new DesignerActionPropertyItem("EnableWaterText", "启用水印文字",
                "WaterText"));
            if (EnableWaterText)
            {
                items.Add(new DesignerActionPropertyItem("WaterText", "水印文字",
                        "WaterText", "失去焦点 & 没有文字 时显示的提示信息"));
            }

            return items;
        }

        //EnterSound实现
        public bool EnterSound
        {
            get
            {
                return this.txtbox.EnterSound;
            }
            set
            {
                this.SetValue("EnterSound", value);
            }
        }

        //Watertext实现
        public string WaterText
        {
            get
            {
                return this.txtbox.WaterText;
            }
            set
            {
                this.SetValue("WaterText", value);
            }
        }

        //WaterText开关
        public bool EnableWaterText
        {
            get
            {
                return txtbox.EnableWaterText;
            }
            set
            {
                this.SetValue("EnableWaterText", value);
                //刷新任务面板
                this.desUiSvc.Refresh(this.Component);
            }
        }

        //Text实现
        public string Text
        {
            get
            {
                return txtbox.Text;
            }
            set
            {
                this.SetValue("Text", value);
            }
        }

        //EnableHighlightBorder实现
        public bool EnableHighlightBorder
        {
            get
            {
                return txtbox.EnableHighlightBorder;
            }
            set
            {
                SetValue("EnableHighlightBorder", value);
            }
        }

        //Multiline实现
        public bool Multiline
        {
            get
            { return txtbox.Multiline; }
            set
            {
                SetValue("Multiline", value);
            }
        }

        // Helper method to retrieve control properties. Use of 
        // GetProperties enables undo and menu updates to work properly.
        //反射 Property SetValue,否则Designer界面 designer代码 属性窗格 不同步
        private PropertyDescriptor GetPropertyByName(String propName)
        {
            PropertyDescriptor prop;
            prop = TypeDescriptor.GetProperties(this.txtbox)[propName];
            if (null == prop)
                throw new ArgumentException(
                     "Matching ColorLabel property not found!",
                      propName);
            else
                return prop;
        }
        private void SetValue(string propName, object value)
        {
            this.GetPropertyByName(propName).SetValue(txtbox, value);
        }
    }
}
