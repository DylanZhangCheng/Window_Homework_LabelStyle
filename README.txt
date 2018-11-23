对MainMenuPage.xaml.cs进行修改，增加label点击样式函数，实现点击相应章节label时，对该label进行高亮蓝色显示。

更改代码如下：
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