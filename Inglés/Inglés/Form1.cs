namespace Inglés
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtpalabra.Text == "")
            {
                MessageBox.Show("Digite la palabra");
            }
            else
            {
                if (txtpalabra.Text == "frightening" || txtpalabra.Text == "FRIGHTENING" || txtpalabra.Text == "Frightening")
                {
                    MessageBox.Show("¡Es correcto!");
                    pictverde1.Visible = true;
                    pictrojo1.Visible = false;
                }
                else
                {
                    MessageBox.Show("Incorrecto");
                    pictverde1.Visible = false;
                    pictrojo1.Visible = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.ckc.Checked == true)
            {
                MessageBox.Show("¡Es correcto FELICITACIONES!");
                pictverde.Visible = true;
                pictrojo.Visible = false;
                cka.Visible = false;
                ckb.Visible = false;
                ckc.Visible = false;
                label17.Visible = true;
                pictVerdeI.Visible = true;
                label18.Visible = true;
                pictRojoI.Visible = true;
                label19.Visible = true;
                pictRojoII.Visible = true;
                label20.Visible = true;
                label21.Visible = true;
            }
            else
            {
                MessageBox.Show("La respuesta es incorrecta");
                pictrojo.Visible = true;
                pictverde.Visible = false;
                cka.Visible = false;
                ckb.Visible = false;
                ckc.Visible = false;
                label17.Visible = true;
                pictVerdeI.Visible = true;
                label18.Visible = true;
                pictRojoI.Visible = true;
                label19.Visible = true;
                pictRojoII.Visible = true;
                label20.Visible = true;
                label22.Visible = true;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.cka1.Checked == true)
            {
                MessageBox.Show("¡Es correcto FELICITACIONES!");
                pictverde2.Visible = true;
                pictrojo2.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
            }
            else
            {
                MessageBox.Show("La respuesta es incorrecta");
                pictrojo2.Visible = true;
                pictverde2.Visible = false;
                cka1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.ckb3.Checked == true)
            {
                MessageBox.Show("¡Es correcto FELICITACIONES!");
                pictverde3.Visible = true;
                pictrojo3.Visible = false;
                checkBox1.Visible = false;
                checkBox4.Visible = false;
            }
            else
            {
                MessageBox.Show("La respuesta es incorrecta");
                pictrojo3.Visible = true;
                pictverde3.Visible = false;
                ckb3.Visible = false;
                checkBox1.Visible = false;
                checkBox4.Visible = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.ckb4.Checked == true)
            {
                MessageBox.Show("¡Es correcto FELICITACIONES!");
                pictverde4.Visible = true;
                pictrojo4.Visible = false;
                checkBox5.Visible = false;
                checkBox7.Visible = false;
            }
            else
            {
                MessageBox.Show("La respuesta es incorrecta");
                pictrojo4.Visible = true;
                pictureBox100.Visible = false;
                ckb4.Visible = false;
                checkBox5.Visible = false;
                checkBox7.Visible = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.ckc5.Checked == true)
            {
                MessageBox.Show("¡Es correcto FELICITACIONES!");
                pictverde5.Visible = true;
                pictrojo5.Visible = false;
                checkBox6.Visible = false;
                checkBox8.Visible = false;
            }
            else
            {
                MessageBox.Show("La respuesta es incorrecta");
                pictrojo5.Visible = true;
                pictverde5.Visible = false;
                ckc5.Visible = false;
                checkBox6.Visible = false;
                checkBox8.Visible = false;

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.ckb6.Checked == true)
            {
                MessageBox.Show("¡Es correcto FELICITACIONES!");
                pictverde6.Visible = true;
                pictrojo6.Visible = false;
                checkBox9.Visible = false;
                checkBox11.Visible = false;
            }
            else
            {
                MessageBox.Show("La respuesta es incorrecta");
                pictrojo6.Visible = true;
                pictverde6.Visible = false;
                ckb6.Visible = false;
                checkBox9.Visible = false;
                checkBox11.Visible = false;
            }
        }
    }
}