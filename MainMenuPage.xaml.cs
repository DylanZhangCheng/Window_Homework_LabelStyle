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

namespace WPFTest.UI.Menu
{
    /// <summary>
    /// TopMenuPage.xaml 的交互逻辑
    /// </summary>
    public partial class MainMenuPage : ChildPage
    {
        public MainMenuPage()
        {
            InitializeComponent();
			label_number = label2;//程序启动，默认上一个点击label为label2
        }
		
		//上一个点击label
		private Label label_number;		
		//label点击样式函数
		private void label_Click(Label label)
		{
			label.Background = Brushes.SkyBlue;
		}
		//label未点击样式函数
		private void label_Notclick(Label label)
		{
			label.Background = Brushes.Transparent;
		}
		//label响应点击更改样式函数
		private void label_Setstyle(Label label)
		{
			label_Notclick(label_number);
			label_Click(label);
			label_number = label;
		}

		private void label1_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {			
			parentWindow.createLeftMenuPage("chapter0");
        }

        private void label2_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
			Label label = (Label)sender;//从sender中获取label（下同）
			label_Setstyle(label);//设置点击样式（下同）
			parentWindow.createLeftMenuPage("chapter1");
        }

        private void label3_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
			Label label = (Label)sender;
			label_Setstyle(label);
			parentWindow.createLeftMenuPage("chapter2");
        }

        private void label4_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
			Label label = (Label)sender;
			label_Setstyle(label);
			parentWindow.createLeftMenuPage("chapter3");
        }

        private void label5_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
			Label label = (Label)sender;
			label_Setstyle(label);
			parentWindow.createLeftMenuPage("chapter4");
        }

        private void label6_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
			Label label = (Label)sender;
			label_Setstyle(label);
			parentWindow.createLeftMenuPage("chapter5");
        }

        private void label7_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
			Label label = (Label)sender;
			label_Setstyle(label);
			parentWindow.createLeftMenuPage("chapter6");
        }

        private void label8_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
			Label label = (Label)sender;
			label_Setstyle(label);
			parentWindow.createLeftMenuPage("chapter7");
        }

        private void label9_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            parentWindow.createLeftMenuPage("chapter8");
        }

        private void ChildPage_Loaded_1(object sender, RoutedEventArgs e)
        {
            parentWindow.createLeftMenuPage("chapter1");
        }
    }
}
