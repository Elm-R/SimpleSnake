namespace SimpleSnake
{
    public partial class Form1 : Form
    {


        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();



        public Form1()
        {
            InitializeComponent();

            // default settings
            new Settings();

            //  game speed and start timer

            gameTimer.Interval = 1000 / Settings.Speed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();

            // start a new game
            StartGame();

        }

        private void StartGame()
        {

            lblGameOver.Visible = false;

            // default settings when starting a new game after a gameover
            new Settings();

            // create a new player 
            Snake.Clear();  // clearing the sanke from the previous game
            Circle head = new Circle();
            head.X = 10;         // trying to place the snake in the middle of the screen
            head.Y = 5;
            Snake.Add(head);

            lblScore.Text = Settings.Score.ToString();

            generateFood();


        }

        private void generateFood()
        {
            // placing the food object randomly

            int maxXPos = pbCanvas.Size.Width / Settings.Width;
            int maxYPos = pbCanvas.Size.Height / Settings.Height;

            Random random = new Random();
            food = new Circle();

            food.X = random.Next(0, maxXPos);
            food.Y = random.Next(0, maxYPos);

        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            // check if gameover is true -> start a new game after pressing enter
            // listen to keyboard input

            // check if game over is true

            if (Settings.GameOver == true)
            {

                // check if enter is pressed

                if (Input.KeyPressed(Keys.Enter))
                {
                    StartGame();
                }
            }
            else
                {   // prevents the snake from colliding with itself
                    if (Input.KeyPressed(Keys.Right) && Settings.direction != Direction.Left)
                        Settings.direction = Direction.Right;
                    else if (Input.KeyPressed(Keys.Left) && Settings.direction != Direction.Right)
                        Settings.direction = Direction.Left;
                    else if (Input.KeyPressed(Keys.Up) && Settings.direction != Direction.Down)
                        Settings.direction = Direction.Up;
                    else if (Input.KeyPressed(Keys.Down) && Settings.direction != Direction.Up)
                        Settings.direction = Direction.Down;

                    MovePlayer();
                }

                pbCanvas.Invalidate();      // refresh data 

            





        }






        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;       // which canvas to use?

            if (!Settings.GameOver)
            {
                // set the colour of the snake
                Brush snakeColour;

                for (int i = 0; i < Snake.Count; i++)
                {

                    if (i == 0)
                        snakeColour = Brushes.Black;    // head

                    else
                        snakeColour = Brushes.Green;    // body

                    // draw snake
                    canvas.FillEllipse(snakeColour,
                        new Rectangle(Snake[i].X * Settings.Width,
                                      Snake[i].Y * Settings.Height,
                                      Settings.Width, Settings.Height));

                    // draw food
                    canvas.FillEllipse(Brushes.Red,
                        new Rectangle(food.X * Settings.Width,
                                      food.Y * Settings.Height,
                                      Settings.Width, Settings.Height));


                }

            }
            else
            {
                string gameOver = "Game over \n Your final score is: " + Settings.Score +
                    " Press enter to try again";

                lblGameOver.Text = gameOver;
                lblGameOver.Visible = true;

            }

        }



        private void MovePlayer()
        {
            // moving the snake: redraw each circle of the snake 
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                // move head
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case Direction.Right:
                            Snake[i].X++;
                            break;


                        case Direction.Left:
                            Snake[i].X--;
                            break;

                        case Direction.Up:
                            Snake[i].Y--;
                            break;

                        case Direction.Down:
                            Snake[i].Y++;
                            break;



                    }

                    // Get maximum X and Y Pos
                    int maxXPos = pbCanvas.Size.Width / Settings.Width;
                    int maxYPos = pbCanvas.Size.Height / Settings.Height;

                    //Detect collission with game borders.
                    if (Snake[i].X < 0 || Snake[i].Y < 0
                        || Snake[i].X >= maxXPos || Snake[i].Y >= maxYPos)
                    {
                        Die();
                    }


                    //Detect collission with body
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X &&
                           Snake[i].Y == Snake[j].Y)
                        {
                            Die();
                        }
                    }

                    //Detect collision with food piece
                    if (Snake[0].X == food.X && Snake[0].Y == food.Y)
                    {
                        Eat();
                    }


                }


                else
                {
                    // move body
                    Snake[i].X = Snake[i - 1].X;    // each cricle replaces the one in front

                    Snake[i].Y = Snake[i - 1].Y;
                }


            }


        }


        private void Die()
        {
            Settings.GameOver = true;
        }



        private void Eat()
        {
             Circle food = new Circle();
            food.X = Snake[Snake.Count - 1].X;
            food.Y = Snake[Snake.Count - 1].Y;

            Snake.Add(food);

            // update score 

            Settings.Score += Settings.Points;

            lblScore.Text = Settings.Score.ToString();

            generateFood();

        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }






        
    }


}