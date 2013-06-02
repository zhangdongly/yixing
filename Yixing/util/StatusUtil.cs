using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Yixing.model;
using Yixing.UserTool;

namespace Yixing.util
{
    class StatusUtil
    {
        public static void addStatus2EXListView(Status st,EXListView exListView,int index)
        {
            EXListViewItem item = new EXListViewItem(st.getZtName());
            item.SubItems.Add(""+st.mahe);
            if (st.isyj)
            {
                st.isyj = true;
                item.SubItems.Add(""+st.dslxs);
            }
            else
            {
                EXListViewSubItem sub = new EXListViewSubItem(""+st.dslxs, Color.Red, Color.White);
                item.SubItems.Add(sub);
            }
            item.Tag = index;
            exListView.Items.Add(item);


        }
    }
}
