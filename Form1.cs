using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova2
{
    public partial class Form1 : Form
    {

        double contagem = 0;

        public string MostraBalanco()
        {
            return lblBalanco.Text = "Resultado Bruto: " + "R$ " + contagem.ToString("F2")
                    + " | " + "Imposto: 9%" + " | " + "Valor líquido: R$ " +
                   (contagem - contagem * 0.09).ToString("F2") + "\n" + "\n" +
                   "Última atualização: " + DateTime.Now;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program p = new Program();
            try
            {

                int assento = int.Parse(txtCadAssento.Text);

            bool verificaAssento = true;

            
                for (int i = listBox1.Items.Count - 1; i >= 0; i--)
                {
                    if (listBox1.Items[i].ToString().Contains(txtCadAssento.Text))
                    {
                        MessageBox.Show("Assento indisponível!");
                        verificaAssento = false;
                    }
                }

                if (txtCadAssento.Text == "1" && verificaAssento)
                {


                    string nome = txtCadNome.Text;




                    listBox1.Items.Add("Cliente: " + nome + " | " + "Assento: " + assento);
                    lbl1.BackColor = Color.Red;
                    string rg = txtRg.Text;

                    listBox2.Items.Add("Cliente: " + nome + " | " + "RG: " + rg + " | " +
                        DateTime.Now);



                    contagem += 20.00;

                    MostraBalanco();
                    txtCadAssento.Clear();
                    txtCadNome.Clear();
                    txtRg.Clear();

                }

                if (txtCadAssento.Text == "2" && verificaAssento)
                {
                    string nome = txtCadNome.Text;




                    listBox1.Items.Add("Cliente: " + nome + " | " + "Assento: " + assento);
                    lbl2.BackColor = Color.Red;
                    string rg = txtRg.Text;

                    listBox2.Items.Add("Cliente: " + nome + " | " + "RG: " + rg + " | " +
                        DateTime.Now);


                    contagem += 20.00;

                    MostraBalanco();
                    txtCadAssento.Clear();
                    txtCadNome.Clear();
                    txtRg.Clear();


                }

                if (txtCadAssento.Text == "3" && verificaAssento)
                {
                    string nome = txtCadNome.Text;




                    listBox1.Items.Add("Cliente: " + nome + " | " + "Assento: " + assento);
                    lbl3.BackColor = Color.Red;
                    string rg = txtRg.Text;

                    listBox2.Items.Add("Cliente: " + nome + " | " + "RG: " + rg + " | " +
                         DateTime.Now);

                    contagem += 20.00;

                    MostraBalanco();
                    txtCadAssento.Clear();
                    txtCadNome.Clear();
                    txtRg.Clear();

                }

                if (txtCadAssento.Text == "4" && verificaAssento)
                {
                    string nome = txtCadNome.Text;




                    listBox1.Items.Add("Cliente: " + nome + " | " + "Assento: " + assento);
                    lbl4.BackColor = Color.Red;
                    string rg = txtRg.Text;

                    listBox2.Items.Add("Cliente: " + nome + " | " + "RG: " + rg + " | " +
                        DateTime.Now);

                    contagem += 20.00;

                    MostraBalanco();
                    txtCadAssento.Clear();
                    txtCadNome.Clear();
                    txtRg.Clear();

                }
                if (txtCadAssento.Text == "5" && verificaAssento)
                {
                    string nome = txtCadNome.Text;




                    listBox1.Items.Add("Cliente: " + nome + " | " + "Assento: " + assento);
                    lbl5.BackColor = Color.Red;
                    string rg = txtRg.Text;

                    listBox2.Items.Add("Cliente: " + nome + " | " + "RG: " + rg + " | " +
                        DateTime.Now);

                    contagem += 20.00;

                    MostraBalanco();
                    txtCadAssento.Clear();
                    txtCadNome.Clear();
                    txtRg.Clear();


                }
                if (txtCadAssento.Text == "6" && verificaAssento)
                {
                    string nome = txtCadNome.Text;




                    listBox1.Items.Add("Cliente: " + nome + " | " + "Assento: " + assento);
                    lbl6.BackColor = Color.Red;
                    string rg = txtRg.Text;

                    listBox2.Items.Add("Cliente: " + nome + " | " + "RG: " + rg + " | " +
                         DateTime.Now);

                    contagem += 20.00;

                    MostraBalanco();
                    txtCadAssento.Clear();
                    txtCadNome.Clear();
                    txtRg.Clear();

                }
                if (assento > 6 || assento < 1)
                {
                    MessageBox.Show("Escolha inválida! - Escolha entre 1 e 6");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato incorreto! Digite um tipo de assento válido");
            }
            



















        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja cancelar essa" +
                " passagem?", "Confirmação", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes) {

                if (listBox1.SelectedItem.ToString().Contains("1"))
                {
                    lbl1.BackColor = Color.Green; 

                }
                if (listBox1.SelectedItem.ToString().Contains("2"))
                {
                    lbl2.BackColor = Color.Green;
                }
                if (listBox1.SelectedItem.ToString().Contains("3"))
                {
                    lbl3.BackColor = Color.Green;
                }
                if (listBox1.SelectedItem.ToString().Contains("4"))
                {
                    lbl4.BackColor = Color.Green;
                }
                if (listBox1.SelectedItem.ToString().Contains("5"))
                {
                    lbl5.BackColor = Color.Green;
                }
                if (listBox1.SelectedItem.ToString().Contains("6"))
                {
                    lbl6.BackColor = Color.Green;
                }

                contagem -= 20.00;

                MostraBalanco();

                listBox1.Items.Remove(listBox1.SelectedItem);
              
            }

            
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            lblBalanco.Visible = true;
        }

        private void lbl1_MouseHover(object sender, EventArgs e)
        {
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

          
        }

        private void btnRg_Click(object sender, EventArgs e)
        {
            listBox2.Visible = true;
        }

        private void btnEscondeRG_Click(object sender, EventArgs e)
        {
            listBox2.Visible = false;
        }
    }
}
