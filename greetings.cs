public SplashScreen()
{
	InitializeComponent();
	Timer t = new Timer();
	t.Interval = 6000;
	t.Start();
	t.Tick += new EventHandler(t_Tick);

	timer1.Start()

	Opacity = 0;
	Timer timer = new Timer();
	timer.Tick += new EventHandler((sender, e) =>
	{
		if ((Opacity += 0.005d) == 1) timer.Stop();
	});
}

void t_Tick(object sender, EventArgs e)
{
	Close();
}
Application.Run(new SplashScreen());