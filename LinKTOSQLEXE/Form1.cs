using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LinKTOSQLEXE
{
    public partial class Form1 : Form
    {
        DataClasses1DataContext d = new DataClasses1DataContext();
        public Form1()
        {
            InitializeComponent();
        }

       
        public void misajour()
        {
            // datagrid des voiture
            var ed = from edi in d.voiture
                     select new { Matricule = edi.immatricule, Marque = edi.marque };
            dataGridView1.DataSource = ed;
            



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // combobox des voiture 

            var ed1 = from edi in d.voiture
                      select new { Matricule = edi.immatricule, Marque = edi.marque };
            cbvoiture.DisplayMember = "Marque";
            cbvoiture.ValueMember = "Matricule";
            cbvoiture.DataSource = ed1;

            // 

            misajour();

        }

       

       

        private void btnnext_Click(object sender, EventArgs e)
        {
            

            //Now write this code in buttonClick
          
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            var ed = from edi in d.voiture
                     where edi.immatricule.Contains(txtfind.Text) || edi.marque.Contains(txtfind.Text)
                     select new { Matricule = edi.immatricule, Marque = edi.marque };
            dataGridView1.DataSource = ed;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            voiture v = new voiture();
            v.immatricule = txtmatricule.Text;
            v.marque = txtmarque.Text;
            v.Modele = txtmodele.Text;
            v.TelephonePro = txttelephone.Text;
            d.voiture.InsertOnSubmit(v);
            d.SubmitChanges();      
            misajour();

        }

        private void btnsupprime_Click(object sender, EventArgs e)
        {
            voiture v = (from c in d.voiture where c.immatricule==txtmatricule.Text select c).Single() ;
            d.voiture.DeleteOnSubmit(v);
            d.SubmitChanges();
            misajour();


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmatricule.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtmarque.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

        }

       

        private void cbvoiture_SelectedIndexChanged(object sender, EventArgs e)
        {
            // il faut vider les textbox (databiend des textboxs)
            txtmatricule.DataBindings.Clear();
            txtmarque.DataBindings.Clear();
            txtmodele.DataBindings.Clear();
            txttelephone.DataBindings.Clear();
            //
            //jointure 
            var ed = (from edr in d.Reparation
                      join voi in d.voiture
                      on edr.immatricule equals voi.immatricule
                      where (edr.immatricule.Equals(cbvoiture.SelectedValue))
                      select edr);
            // remplir de listbox
            lstreparation.DisplayMember = "dateReparation";
            lstreparation.ValueMember = "idReparation";
            lstreparation.DataSource = ed;
            // remplir des textbox
            txtmatricule.DataBindings.Add("text", ed, "idReparation");
            txtmarque.DataBindings.Add("text", ed, "dateReparation");
            txtmodele.DataBindings.Add("text", ed, "PrixReparation");
            txttelephone.DataBindings.Add("text", ed, "idGarage");
         
        }

        private void lstreparation_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var edi = (from edr in d.Reparation
            //           where (Convert.ToInt32(edr.idReparation) == Convert.ToInt32(lstreparation.SelectedValue))
            //           select edr);

            //txtmatricule.Text = Convert.ToString( lstreparation.SelectedValue);
            //txtmarque.Text = lstreparation.Text;

        }
    }
}
