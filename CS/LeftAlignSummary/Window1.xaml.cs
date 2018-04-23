using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections;
using DevExpress.Data;
using DevExpress.Xpf.Grid;

namespace LeftAlignSummary {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
            List<Record> list = new List<Record>();
            list.Add(new Record() { GroupName = "Group A", Value = 19 });
            list.Add(new Record() { GroupName = "Group B", Value = 30 });
            list.Add(new Record() { GroupName = "Group A", Value = 15 });
            list.Add(new Record() { GroupName = "Group C", Value = 42 });
            gridControl1.ItemsSource = list;
            gridControl1.Columns["GroupName"].GroupIndex = 0;
        }
    }

    public sealed class HiddenSummaryTemplateSelector : DataTemplateSelector {
        static readonly DataTemplate EmptyTemplate = new DataTemplate();

        public override DataTemplate SelectTemplate(object item, DependencyObject container) {
            GridGroupSummaryData data = item as GridGroupSummaryData;
            if(data.SummaryItem.SummaryType == SummaryItemType.Count)
                return EmptyTemplate;

            return base.SelectTemplate(item, container);
        }
    }

    public class Record {
        public string GroupName { get; set; }
        public int Value { get; set; }
    }
}
