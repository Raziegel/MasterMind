using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MasterMind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Color[] Resultat = new Color[4];
        int NbTours = 0;
        Random rando = new Random();
        public MainWindow()
        {
            InitializeComponent();
            
            Color Couleur1 = new Color(rando);           
            Color Couleur2 = new Color(rando);
            Color Couleur3 = new Color(rando);
            Color Couleur4 = new Color(rando);
            
            Resultat[0] = Couleur1;
            Resultat[1] = Couleur2;
            Resultat[2] = Couleur3;
            Resultat[3] = Couleur4;
            Array TabEnum = Enum.GetValues(typeof(ColorName));
            Color1.Items.Clear();
            foreach (var item1 in TabEnum)
            {
                
                Color1.Items.Add(item1);
            }
            Color2.Items.Clear();
            foreach (var item2 in TabEnum)
            {
                
                Color2.Items.Add(item2);
            }
            Color3.Items.Clear();
            foreach (var item3 in TabEnum)
            {
                
                Color3.Items.Add(item3);
            }
            Color4.Items.Clear();
            foreach (var item4 in TabEnum)
            {
                Color4.Items.Add(item4);
            }
            ColumnDefinition NumEssai = new ColumnDefinition();
            ColumnDefinition ColCouleur1 = new ColumnDefinition();
            ColumnDefinition ColCouleur2 = new ColumnDefinition();
            ColumnDefinition ColCouleur3 = new ColumnDefinition();
            ColumnDefinition ColCouleur4 = new ColumnDefinition();

            Historique.ColumnDefinitions.Add(NumEssai);
            Historique.ColumnDefinitions.Add(ColCouleur1);
            Historique.ColumnDefinitions.Add(ColCouleur2);
            Historique.ColumnDefinitions.Add(ColCouleur3);
            Historique.ColumnDefinitions.Add(ColCouleur4);
            RowDefinition Titre = new RowDefinition();
            Titre.Height = new GridLength(45);
            Historique.RowDefinitions.Add(Titre);

        }

        private void Test_Click(object sender, RoutedEventArgs e)
        {
            NbTours++;
            NbTest.Content = NbTours;
            if (Color1.SelectedItem.ToString() == Resultat[0].Couleur.ToString())
            {
                Etat1.Content = "Bonne Place";
            }
            else
            {
                for (int i = 0; i < Resultat.Length; i++)
                {
                    if (Color1.SelectedItem.ToString() == Resultat[i].Couleur.ToString())
                    {
                        Etat1.Content = "La couleur existe mais est mal placée";
                        break;
                    }
                    else
                    {
                        Etat1.Content = "La couleur n'existe pas";
                    }
                }
               

            }

            if (Color2.SelectedItem.ToString() == Resultat[1].Couleur.ToString())
            {
                Etat2.Content = "Bonne Place";
            }
            else
            {
                for (int i = 0; i < Resultat.Length; i++)
                {
                    if (Color2.SelectedItem.ToString() == Resultat[i].Couleur.ToString())
                    {
                        Etat2.Content = "La couleur existe mais est mal placée";
                        break;
                    }
                    else
                    {
                        Etat2.Content = "La couleur n'existe pas";
                    }
                }
            }

            if (Color3.SelectedItem.ToString() == Resultat[2].Couleur.ToString())
            {
                Etat3.Content = "Bonne Place";
            }
            else
            {
                for (int i = 0; i < Resultat.Length; i++)
                {
                    if (Color3.SelectedItem.ToString() == Resultat[i].Couleur.ToString())
                    {
                        Etat3.Content = "La couleur existe mais est mal placée";
                        break;
                    }
                    else
                    {
                        Etat3.Content = "La couleur n'existe pas";
                    }
                }
            }
            
            if (Color4.SelectedItem.ToString() == Resultat[3].Couleur.ToString())
            {
                Etat4.Content = "Bonne Place";
            }
            else
            {
                for (int i = 0; i < Resultat.Length; i++)
                {
                    if (Color4.SelectedItem.ToString() == Resultat[i].Couleur.ToString())
                    {
                        Etat4.Content = "La couleur existe /n mais est mal placée";
                        break;
                    }
                    else
                    {
                        Etat4.Content = "La couleur n'existe pas";
                    }
                }
            }
            if (Etat1.Content.ToString() == "Bonne Place" && Etat2.Content.ToString() == "Bonne Place" && Etat3.Content.ToString() == "Bonne Place" && Etat4.Content.ToString() == "Bonne Place" )
            {
                NbTest.Content = "Victoire au bout de : " + NbTours + " tours.";
            }
            else if( NbTours >= 10)
            {
                NbTest.Content = "Tour 10 dépassé : Défaite";
            }

            RowDefinition essai = new RowDefinition();
            essai.Height = new GridLength(45);

            TextBlock C1 = new TextBlock();
            C1.Text = Color1.SelectedItem.ToString();
            Historique.RowDefinitions.Add(essai);
            Grid.SetRow(C1, 0);
            Grid.SetColumn(C1, 0);
            //tentative de remplissage de grid
        }
    }
}
