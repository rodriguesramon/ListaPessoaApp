using System;
using System.Collections.Generic;
using ListaPessoaApp.Model;
using Xamarin.Forms;

namespace ListaPessoaApp
{
    public partial class PageListViewPessoa : ContentPage
    {
        public PageListViewPessoa(List<Pessoa> listaPessoa)
        {
            InitializeComponent();
            listView_dadosPessoas.ItemsSource = listaPessoa;
        }

        void Voltar(object sender, System.EventArgs e)
        {

        }
    }
}
