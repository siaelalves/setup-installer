using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Setup
{
    public partial class SETUP : Form
    {
        public int NúmeroDaEtapa = 1;
        public string NotaDeAbertura = @"Opening.rtf";
        public string ArquivoDeLicença = @"License.rtf";
        public string ArquivoDeInstruções = @"Instructions.rtf";
        public string ArquivoDeÍcone = @"D:\Projetos\C#\Concluídos\Writer\bin\Release\writer.ico";
        public string[] ArquivosNecessários = {@"Instructionss.rtf", 
                                                  @"LICENSEs.rtf", 
                                                  @"Openings.rtf",
                                                  @"Thankss.rtf"};
        public string NomeDoAplicativo= "Escritor";
        public string DescriçãoDoAplicativo = "Crie qualquer texto com este aplicativo!";
        public string VersãoDoAplicativo = "1.0.0.0";
        public string Autor = "Siael Carvalho";
        public string DiretórioDoAplicativo = @"C:" + "\\" + "Program Files (x86)" +
                "\\" + "SAKSYS" + "\\" + "Escritor 1.0.0.0";
        public string Empresa = "SAKSYS";

        public void ConseguirPermissão(string caminho, string usuário,
            System.Security.AccessControl.FileSystemRights permissões,
            System.Security.AccessControl.AccessControlType tipoDeControle)
        {
            // Create a new DirectoryInfo object.
            System.IO.DirectoryInfo infoD = new System.IO.DirectoryInfo(caminho);
            // Get a DirectorySecurity object that represents the  
            // current security settings.
            System.Security.AccessControl.DirectorySecurity segurançaD = infoD.GetAccessControl();
            // Add the FileSystemAccessRule to the security settings.
            segurançaD.AddAccessRule(new System.Security.AccessControl.
                FileSystemAccessRule(usuário, permissões, tipoDeControle));
            // Set the new access settings.
            infoD.SetAccessControl(segurançaD);
            return;
        }

        public void ConfigurarEtapa()
        {
            if (NúmeroDaEtapa == 1)
            {
                goto Abertura;
            }
            if (NúmeroDaEtapa == 2)
            {
                goto Licença;
            }
            if (NúmeroDaEtapa  == 3)
            {
                goto Instalação;
            }
            if (NúmeroDaEtapa == 4)
            {
                goto Finalização;
            }
         Abertura:
            lblAg.Text = "Seja bem-vindo!";
            txtLic.LoadFile(NotaDeAbertura);
            txtLic.Text.Replace("%apptitle%", NomeDoAplicativo).
                Replace("%whatappdo%", DescriçãoDoAplicativo).
                Replace("%PRODUTO%", NomeDoAplicativo).
                Replace("%EMPRESA%", Empresa).
                Replace("%EMPRESA_SIGLA%", "SAKSYS").
                Replace("%AUTOR%", Autor).
                Replace("%appDirectory%", DiretórioDoAplicativo);
            cmdPr.Text = "Próximo >";
            cmdVl.Enabled = false;
            return;

          Licença:
            lblAg.Text = "1. Contrato de Licença";
            txtLic.LoadFile(ArquivoDeLicença);
            cmdPr.Text = "Co&ncordo";
            cmdVl.Enabled = true;
            return;

          Instalação:
            lblAg.Text = "2. Instalação";
            txtLic.LoadFile(ArquivoDeInstruções);
            cmdPr.Text = "Instalar";
            return;

        Finalização:
            ConseguirPermissão(@DiretórioDoAplicativo,
                "user", System.Security.AccessControl.FileSystemRights.CreateFiles,
                 System.Security.AccessControl.AccessControlType.Allow);

            foreach (string f in ArquivosNecessários)
            {
                System.IO.File.Copy(@f, @DiretórioDoAplicativo + "\\" + 
                    new System.IO.FileInfo(f).Name);
                txtLic.Clear();
                txtLic.AppendText(f + " copiado.");
                txtLic.AppendText("Arquivos copiados com sucesso!");
            }
            ConseguirPermissão(@DiretórioDoAplicativo,
                "user", System.Security.AccessControl.FileSystemRights.CreateFiles,
                 System.Security.AccessControl.AccessControlType.Deny);
            ConseguirPermissão(@DiretórioDoAplicativo,
        }

        public SETUP()
        {
            InitializeComponent();
        }

        private void SETUP_Load(object sender, EventArgs e)
        {
            lblTt.Text = NomeDoAplicativo + " " + VersãoDoAplicativo;
            lblDs.Text = DescriçãoDoAplicativo;
            picLogo.ImageLocation = @"setup.ico";
            ConfigurarEtapa();
        }

        private void cmdCnc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdPr_Click(object sender, EventArgs e)
        {
            NúmeroDaEtapa += 1;
            ConfigurarEtapa();
        }

        private void cmdVl_Click(object sender, EventArgs e)
        {
            NúmeroDaEtapa -= 1;
            ConfigurarEtapa();
        }
    }
}
