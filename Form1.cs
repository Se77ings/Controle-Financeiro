using Controle_Financeiro.controller;
using Controle_Financeiro.data;
using System.Drawing.Text;

namespace Controle_Financeiro
{
    public partial class Login : Form
    {
        private DataContext context;
        private UserController userController;
        public Login()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {


            context = new DataContext(); // Certifique-se de que DataContext esteja configurado corretamente
            userController = new UserController(context);


            var user = inputName.Text;
            var pwd = inputPwd.Text;
            var cpwd = inputConfirmPwd.Text;

            if (user == "")
            {
                MessageBox.Show("O usuário não pode ser vazio", "Atenção!");
                return;
            }
            else
            if (pwd == "")
            {
                MessageBox.Show("A senha não pode ser vazia", "Atenção!");
                return;
            }
            else
            if (cpwd == "")
            {
                MessageBox.Show("Preencha o campo de confirmar senha!", "Atenção!");
                return;

            }

            if (pwd != cpwd)
            {
                MessageBox.Show("As senhas não coincidem", "Atenção!");
                return;
            }

            try
            {
                userController.Create(user, pwd);
                MessageBox.Show("Usuário criado com sucesso!", "Sucesso");
                //redirect!
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.InnerException?.Message, "Erro");
            }
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
