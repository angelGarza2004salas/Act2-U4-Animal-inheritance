using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencia_Act2_U4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCreateDog_Click(object sender, EventArgs e)
        {
            string name = TxtName.Text;
            int age = int.Parse(TxtAge.Text);
            string race = TxtRace.Text;

            Dog dog = new Dog(name, age, race);
            LblInformation.Text = dog.GetCompleteInformation() + ", Sound: " + dog.MakeSound();
        }
    }
}
