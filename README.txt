��MainMenuPage.xaml.cs�����޸ģ�����label�����ʽ������ʵ�ֵ����Ӧ�½�labelʱ���Ը�label���и�����ɫ��ʾ��

���Ĵ������£�
public MainMenuPage()
        {
            InitializeComponent();
			label_number = label2;//����������Ĭ����һ�����labelΪlabel2
        }
		
		//��һ�����label
		private Label label_number;		
		//label�����ʽ����
		private void label_Click(Label label)
		{
			label.Background = Brushes.SkyBlue;
		}
		//labelδ�����ʽ����
		private void label_Notclick(Label label)
		{
			label.Background = Brushes.Transparent;
		}
		//label��Ӧ���������ʽ����
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
			Label label = (Label)sender;//��sender�л�ȡlabel����ͬ��
			label_Setstyle(label);//���õ����ʽ����ͬ��
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