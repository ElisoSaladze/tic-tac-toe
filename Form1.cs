using System;
using System.Diagnostics;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private char[,] board;
        private char currentPlayer;
        private List<string> available = new List<string>();
        bool isFinished = false;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void title_TextChanged(object sender, EventArgs e)
        {

        }

        private async void checkWinner()
        {
            int[][] winningCombinations = {
                new int[] {0, 1, 2}, new int[] {3, 4, 5}, new int[] {6, 7, 8}, // Rows
                new int[] {0, 3, 6}, new int[] {1, 4, 7}, new int[] {2, 5, 8}, // Columns
                new int[] {0, 4, 8}, new int[] {2, 4, 6}                      // Diagonals
            };
            foreach (var combination in winningCombinations)
            {
                int cell1 = combination[0];
                int cell2 = combination[1];
                int cell3 = combination[2];

                char symbol1 = board[cell1 / 3, cell1 % 3];
                char symbol2 = board[cell2 / 3, cell2 % 3];
                char symbol3 = board[cell3 / 3, cell3 % 3];

                if (symbol1 != '\0' && symbol1 == symbol2 && symbol2 == symbol3)
                {
                    isFinished = true;
                    foreach (int cellIndex in combination)
                    {
                        int row = cellIndex / 3;
                        int col = cellIndex % 3;

                        
                        Button button = (Button)table.GetControlFromPosition(col, row);

                        
                        button!.BackColor = Color.FromArgb(233, 157, 143);
                        await Task.Delay(200);
                    }
                    if (symbol1 == 'X')
                    {
                        finishLabel.Text = "You won!";
                    }
                    else
                    {
                        finishLabel.Text = "You lose!";
                    }
                    await Task.Delay(1500);
                    finishPanel.Visible = true;
                    
                    button10.Enabled = false;
                    return;
                }
                bool tie = true;
                foreach (char cellValue in board)
                {
                    if (cellValue == '\0')
                    {
                        tie = false;
                        break;
                    }
                }

                if (tie)
                {
                    finishLabel.Text = "It's a tie!";
                    finishPanel.Visible = true;
                    button10.Enabled = false;
                }
            }
        }

        private async void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            var tag = button.Tag as string;

            if (tag != null)
            {
                string[] parts = tag.Split(',');
                if (parts.Length == 2 && int.TryParse(parts[0], out int row) && int.TryParse(parts[1], out int col))
                {
                    if (board[row, col] == '\0')
                    {
                        available.Remove(tag);

                        board[row, col] = currentPlayer;
                        button.Text = currentPlayer.ToString();
                        checkWinner();
                        currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                        if (available.Count > 0 && !isFinished)
                        {
                            await Task.Delay(1500);
                            computerMove();
                        }

                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                char cellValue = board[i, j];
                                string cellText = (cellValue == '\0') ? " " : cellValue.ToString();
                                Debug.Write(cellText + " ");
                            }
                            Debug.WriteLine("");
                        }
                        checkWinner();
                    }
                }
            }
        }

        private void InitializeComputerMoveTimer()
        {

        }

        private void computerMove()
        {
            Random random = new Random();
            int index = random.Next(available.Count);
            string cell = available[index];

            string[] parts = cell.Split(',');
            if (parts.Length == 2 && int.TryParse(parts[0], out int row) && int.TryParse(parts[1], out int col))
            {
                foreach (Control c in table.Controls)
                    if (c is Button button && button.Tag as string == cell)
                    {
                        button.Text = currentPlayer.ToString();
                        board[row, col] = currentPlayer;
                    }
                currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                available.RemoveAt(index);
            }
        }

        private void play_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            label2.Visible = false;
            play.Visible = false;
            gamePanel.Visible = true;
            initializeBoard();
            addNumbers();
            currentPlayer = 'X';
            finishPanel.Visible = false;
            button10.Enabled = true;
            clearButtonText();
            isFinished = false;
        }

        private void initializeBoard()
        {
            board = new char[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = '\0';
                }
            }
        }

        private void addNumbers()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    available.Add($"{i}, {j}");
                }
            }
        }

        private void clearButtonText()
        {
            foreach (Control control in table.Controls)
            {
                if (control is Button button)
                {
                    button.Text = "";
                    button.BackColor = Color.FromArgb(75, 73, 95);
                }
            }
        }

        private void table_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void finishPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void playAgain_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
