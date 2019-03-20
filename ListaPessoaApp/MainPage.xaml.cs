using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListaPessoaApp.Model;
using Xamarin.Forms;

namespace ListaPessoaApp
{
    public partial class MainPage : ContentPage
    {
        List<Pessoa> listaPessoa = new List<Pessoa>();

        void AdicionarPessoa(object sender, System.EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.nome = campoNome.Text;
            pessoa.sobrenome = campoSobrenome.Text;

            listaPessoa.Add(pessoa);

        }

        void ChecarLista(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new PageListViewPessoa(listaPessoa));
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
