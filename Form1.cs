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
                MessageBox.Show("O usu�rio n�o pode ser vazio", "Aten��o!");
                return;
            }
            else
            if (pwd == "")
            {
                MessageBox.Show("A senha n�o pode ser vazia", "Aten��o!");
                return;
            }
            else
            if (cpwd == "")
            {
                MessageBox.Show("Preencha o campo de confirmar senha!", "Aten��o!");
                return;

            }

            if (pwd != cpwd)
            {
                MessageBox.Show("As senhas n�o coincidem", "Aten��o!");
                return;
            }

            try
            {
                userController.Create(user, pwd);
                MessageBox.Show("Usu�rio criado com sucesso!", "Sucesso");
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
