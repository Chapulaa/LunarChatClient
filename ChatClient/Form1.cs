using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatClient
{
    public partial class Form1 : Form
    {
        //Trata o nome do usuário
        private string nomeUsuario;
        private StreamWriter stwEnviador;
        private StreamReader strReceptor;
        private TcpClient tcpServidor;

        //Necessario para atualizar o formulário com menasagens de outra thread
        private delegate void AtualizarLogCallBack(string strMensagem);

        //Necessario para definir o formulário par o estado disconnected de outra thread
        private delegate void FechaConexaoCallBack(string strMotivo);
        private Thread mensagemThread;
        private IPAddress enderecoIP;
        private int portaHost;
        private bool Conectado;

        public Form1()
        {
            //Na saída da aplicação : desconctar
            Application.ApplicationExit += new EventHandler(OnApplicationExit);

            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            //se não esta conectado aguarda conexão
            if (!Conectado)
            {
                //Inicializa a conexão
                InicializarConexao();

            }
            else
            {
                //Se esta conectado então desconecta
                FecharConexao("Desconectador a pedido do usuário");
            }
        }

        private void txtEnviarMensagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verificar a tecla enter
            if (e.KeyChar == (char)13)
            {
                EnviarMensagem();
            }
        }

        private void InicializarConexao()
        {
            try
            {
                //Trata o endereço ip informado em um objeto IPAdress
                enderecoIP = IPAddress.Parse(txtIp.Texts);
                //Trata o numero da porta do host
                portaHost = (int)txtPorta.Value;
                //Inicia uma nova conexão TCP com o servidor chat
                tcpServidor = new TcpClient();
                tcpServidor.Connect(enderecoIP, portaHost);

                //Ajuda a verificar se estamos conectados
                Conectado = true;

                //Prepara o formulario
                nomeUsuario = txtNomeUsuario.Texts;

                //Desabilita e habilita os campos apropriados
                txtIp.Enabled = false;
                txtPorta.Enabled = false;
                txtNomeUsuario.Enabled = false;
                txtEnviarMensagem.Enabled = true;
                btnEnviarMensagem.Enabled = true;
                btnConectar.ForeColor = Color.Red;
                btnConectar.Text = "Desconectar";

                //Envia o nome de usuário ao servidor
                stwEnviador = new StreamWriter(tcpServidor.GetStream());
                stwEnviador.WriteLine(txtNomeUsuario.Texts);
                stwEnviador.Flush();

                //Inicia a thread para receber mensagens e nova comunicação
                mensagemThread = new Thread(new ThreadStart(ReceberMensagem));
                mensagemThread.IsBackground = true;
                mensagemThread.Start();

                lblStatus.Invoke(new Action(() =>
                {
                    lblStatus.ForeColor = Color.Green;
                    lblStatus.Text = $"Conectado ao Servidor de chat: {enderecoIP}:{portaHost}";
                }));
            }
            catch (Exception ex)
            {
                lblStatus.Invoke(new Action(() =>
                {
                    lblStatus.ForeColor = Color.Red;
                    lblStatus.Text = "Ocorreu um erro ao conectar com o servidor:\n" + ex.Message;
                }));
            }
        }

        private void ReceberMensagem()
        {
            //Recebe a resposta do servidor
            strReceptor = new StreamReader(tcpServidor.GetStream());
            string conResposta = strReceptor.ReadLine();
            //Se o primeiro caracter da resposta é 1 a conexão foi feita com sucesso
            if (conResposta[0] == '1')
            {
                this.Invoke(new AtualizarLogCallBack(this.AtualizaLog), new object[] { "Conectado com sucesso" });
            }
            else
            {
                //Se o primeiro carctere não foir 1 a conexão falhou
                string motivo = "Não conectado: ";
                //Extrai o motivo da mensagem resposta. O motivo começa no 3o caractere
                motivo += conResposta.Substring(2, conResposta.Length - 2);

                this.Invoke(new AtualizarLogCallBack(this.AtualizaLog), new object[] { motivo });
                //Sair do metodo
                return;
            }
            //Enquanto estiver conectado le as linhas que estão chegando do servidor
            while (Conectado)
            {
                this.Invoke(new AtualizarLogCallBack(this.AtualizaLog), new object[] { strReceptor.ReadLine() });
            }
        }

        private void AtualizaLog(string strMensagem)
        {
            //Anexa o texto ao final de cada linha
            txtChat.AppendText( strMensagem + "\r\n");
        }

        private void EnviarMensagem()
        {
            //Envia a mensagem para o servidor
            if (!string.IsNullOrWhiteSpace(txtEnviarMensagem.Texts))
            {
                stwEnviador.WriteLine(txtEnviarMensagem.Texts);
                stwEnviador.Flush();
                txtEnviarMensagem.Texts = string.Empty;
            }
        }

        private void FecharConexao(string Motivo)
        {
            //Fecha a conexão com o servidor
            //Mostra o motivo proque a conexão encerrou
            txtChat.AppendText(Motivo + "\r\n");
            //Habilita e desabilita os campos apropriados
            txtIp.Enabled = true;
            txtPorta.Enabled = true;
            txtNomeUsuario.Enabled = true;
            txtEnviarMensagem.Enabled = false;
            btnEnviarMensagem.Enabled = false;
            btnConectar.ForeColor = Color.Green;
            btnConectar.Text = "Conectar";

            //Fecha objetos
            Conectado = false;
            stwEnviador.Close();
            strReceptor.Close();
            tcpServidor.Close();

            lblStatus.Invoke(new Action(() =>
            {
                lblStatus.ForeColor = Color.Green;
                lblStatus.Text = $"Desconectado ao Servidor de chat: {enderecoIP}:{portaHost}";
            }));
        }

        public void OnApplicationExit(object sender, EventArgs e)
        {
            if (Conectado)
            {
                //Fecha as conexões, streams, etc...
                Conectado = false;
                stwEnviador.Close();
                strReceptor.Close();
                tcpServidor.Close();

                lblStatus.Invoke(new Action(() =>
                {
                    lblStatus.ForeColor = Color.Green;
                    lblStatus.Text = $"Desconectado ao Servidor de chat: {enderecoIP}:{portaHost}";
                }));
            }
        }

        private void btnEnviarMensagem_Click(object sender, EventArgs e)
        {
            EnviarMensagem();
        }
    }
}
