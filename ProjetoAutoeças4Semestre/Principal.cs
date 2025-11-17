using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAutoeças4Semestre
{
    public partial class FPrincipal : Form
    {

        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public FPrincipal()
        {
            InitializeComponent();
        }

        private void CentralizarLabel()
        {
            // Ajusta a label ao tamanho do texto
            lblNameFunction.AutoSize = true;
            lblNameFunction.Refresh();

            // Posição horizontal e vertical central
            int x = (836 - lblNameFunction.Width) / 2;
            int y = (130 - lblNameFunction.Height) / 2;

            // Garante que a posição nunca seja negativa
            lblNameFunction.Left = Math.Max(0, x);
            lblNameFunction.Top = Math.Max(0, y);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void FPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNovoPedido_Click_1(object sender, EventArgs e)
        {
            lblNameFunction.Text = "Novo Pedido";
            lblNameFunction.AutoSize = true;
            CentralizarLabel();
        }

        private void btnNovoCliente_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCliente(), sender);
            lblNameFunction.Text = "Cadastrar Novo Cliente";
            lblNameFunction.AutoSize = true;
            CentralizarLabel();
        }

        private void btnNovoProduto_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProduto(), sender);
            lblNameFunction.Text = "Cadastrar Novo Produto";
            lblNameFunction.AutoSize = true;
            CentralizarLabel();
        }

        private void btnProcurarPedido_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProcuraPedido(), sender);
            lblNameFunction.Text = "Procurar Pedido";
            lblNameFunction.AutoSize = true;
            CentralizarLabel();
        }

        private void btnProcurarProduto_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProcurarProduto(), sender);
            lblNameFunction.Text = "Procurar Produto";
            lblNameFunction.AutoSize = true;
            CentralizarLabel();
        }

        private void btnProcurarCliente_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProcuraCliente(), sender);
            lblNameFunction.Text = "Procurar Cliente";
            lblNameFunction.AutoSize = true;
            CentralizarLabel();
        }
    }
}
