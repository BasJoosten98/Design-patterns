using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Decorator;

namespace DecoratorForm
{
    public partial class Form1 : Form
    {
        private CakeMaker cm;
        public Form1()
        {
            InitializeComponent();
            cm = new CakeMaker();
            displayAllIngredients();
        }

        private void displayAllIngredients()
        {
            foreach(CakeBase cb in cm.GetAllIngredients())
            {
                if(cb is ToppingBase)
                {
                    lbCakeToppings.Items.Add(cb.Name);
                }
                else
                {
                    lbCakePlatform.Items.Add(cb.Name);
                }
            }
        }
        private void btnAddPlatform_Click(object sender, EventArgs e)
        {
            int index = lbCakePlatform.SelectedIndex;
            if(index > -1)
            {
                cm.SetCakeType(lbCakePlatform.Items[index].ToString());
            }
        }

        private void btnAddTopping_Click(object sender, EventArgs e)
        {
            int index = lbCakeToppings.SelectedIndex;
            if (index > -1)
            {
                cm.AddToppingBase(lbCakeToppings.Items[index].ToString());
            }
        }

        private void btnRemoveCake_Click(object sender, EventArgs e)
        {
            cm.RemoveCake();
        }

        private void btnCreateCake_Click(object sender, EventArgs e)
        {
            lbYourCake.Items.Clear();

            CakeBase cake = cm.GetCake();
            if(cake == null) { return; }
            List<CakeBase> wholeCake = cake.CreateCake();
            foreach(CakeBase cb in wholeCake)
            {
                lbYourCake.Items.Add(cb.Name);
            }
        }
    }
}
