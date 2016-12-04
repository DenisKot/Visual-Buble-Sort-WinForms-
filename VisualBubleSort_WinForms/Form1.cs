namespace VisualBubleSort_WinForms
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Source;
    using Timer = System.Windows.Forms.Timer;

    public partial class Form : System.Windows.Forms.Form
    {
        private List<Button> buttons;
        private int[] intArr;

        private Timer timer;
        private int interval = 1;
        private bool isRuning;

        public Form()
        {
            this.buttons = new List<Button>();
            timer = new Timer();
            timer.Interval = interval;

            InitializeComponent();

            this.byStep.Checked = true;
            this.buttonStop.Visible = false;
        }

        private async void sortBtn_Click(object sender, EventArgs e)
        {
            if(this.isRuning)
                return;

            try
            {
                var strArr = this.textBox.Text.Trim().Split(' ');
                this.intArr = Array.ConvertAll(strArr, s => int.Parse(s));

                this.Width = 5 + ButtonFactory.ButtonSize*this.intArr.Length > 600
                    ? ButtonFactory.ButtonSize * this.intArr.Length + 20
                    : 600;

                await this.CreateButtons();
            }
            catch (Exception)
            {
                MessageBox.Show("Некоректно задані данні, спробуйте ще раз.");
            }
        }

        private async Task CreateButtons()
        {
            this.ClearScreen();

            for (int index = 0; index < this.intArr.Length; index++)
            {
                var item = this.intArr[index];
                var btn = ButtonFactory.Create(item, index);
                this.buttons.Add(btn);
                this.Controls.Add(btn);
            }

            await this.Sort();
            //this.CreateSwapAnimation(buttons[0], this.buttons[2]);
        }

        private async Task Sort()
        {
            isRuning = true;
            this.buttonStop.Visible = true;

            var swapped = true;
            int z = 0;
            while (swapped)
            {
                swapped = false;
                
                for (int i = 0; i < this.intArr.Length - 1 - z; i++)
                {
                    if (this.isRuning == false) return;

                    this.SelectButtons(this.buttons[i], this.buttons[i + 1]);
                    await this.SleepLong();

                    if (this.intArr[i] > this.intArr[i + 1])
                    {
                        int a = this.intArr[i];
                        this.intArr[i] = this.intArr[i + 1];
                        this.intArr[i + 1] = a;
                        swapped = true;
                        await this.CreateSwapAnimation(i, i + 1);
                    }

                    this.DiselectButtonsButtons(this.buttons[i], this.buttons[i + 1]);
                }
                z++;
            }

            isRuning = false;
            this.buttonStop.Visible = false;
            MessageBox.Show("Сортування бульбашкою завершене", "Завершено");
        }

        private async Task CreateSwapAnimation(int index1, int index2)
        {
            var btn1 = this.buttons[index1];
            var btn2 = this.buttons[index2];

            var temp = this.buttons[index1];
            this.buttons[index1] = this.buttons[index2];
            this.buttons[index2] = temp;

            var btn1StartPos = btn1.Left;
            var btn2StartPos = btn2.Left;
            
            if (!this.byStep.Checked)
            {
                btn2.Left = btn1StartPos;
                btn1.Left = btn2StartPos;
                await this.Sleep();
                return;
            }

            while (!(btn1StartPos == btn2.Left || btn2StartPos == btn1.Left))
            {
                btn1.Left += 1;
                btn2.Left -= 1;

                await this.Sleep();
            }
        }

        private void SelectButtons(Button btn1, Button btn2)
        {
            btn1.FlatAppearance.BorderColor = ButtonFactory.SelectedBorderColor;
            btn2.FlatAppearance.BorderColor = ButtonFactory.SelectedBorderColor;
        }

        private void DiselectButtonsButtons(Button btn1, Button btn2)
        {
            btn1.FlatAppearance.BorderColor = ButtonFactory.NormalBorderColor;
            btn2.FlatAppearance.BorderColor = ButtonFactory.NormalBorderColor;
        }

        private async Task Sleep()
        {
            this.Refresh();
            if (this.byStep.Checked)
            {
                await Task.Delay(this.interval);
            }
        }

        private async Task SleepLong()
        {
            this.Refresh();
            if (this.byStep.Checked)
            {
                await Task.Delay(1000);
            }
        }

        private void ClearScreen()
        {
            foreach (var btn in this.buttons)
            {
                this.Controls.Remove(btn);
            }

            this.buttons.Clear();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            this.isRuning = false;
            this.buttonStop.Visible = false;
        }
    }
}